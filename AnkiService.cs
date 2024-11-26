using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Net.Http;

namespace AnkiApp
{
    // Card class to map CSV rows
    public class Card
    {
        public string Front { get; set; }
        public string Back { get; set; }
        public string Tags { get; set; }
    }

    public class AnkiService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        private async Task<JToken?> SendAnkiRequestAsync(object payload)
        {
            var url = "http://localhost:8765";
            var jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse is null || jsonResponse == "null")
                return null;
            return JToken.Parse(jsonResponse);
        }

        public async Task DeleteAndCreateDeck(string deckName)
        {
            var deletePayload = new
            {
                action = "deleteDecks",
                @params = new
                {
                    decks = new[] { deckName },
                    cardsToo = true
                },
            };
            await SendAnkiRequestAsync(deletePayload);

            var createPayload = new
            {
                action = "createDeck",
                @params = new
                {
                    deck = deckName,
                }
            };

            await SendAnkiRequestAsync(createPayload);

            var getConfigPayload = new
            {
                action = "getDeckConfig",
                @params = new 
                { 
                    deck = deckName 
                }
            };

            var configResponse = await SendAnkiRequestAsync(getConfigPayload);

            var configId = configResponse["id"];

            // Step 3: Update the configuration for random ordering
            var updateConfigPayload = new
            {
                action = "saveDeckConfig",
                @params = new
                {
                    config = new
                    {
                        decks = new[] { deckName },
                        id = configId,
                        reviewOrder = 8 // Randomize review card order
                    }
                }
            };
            await SendAnkiRequestAsync(updateConfigPayload);
        }

        public async Task AddNotesAsync(string deckName, List<Card> cards)
        {
            var notes = new List<object>();
            foreach (var data in cards)
            {
                var card = new
                {
                    deckName = deckName,
                    modelName = "Basic",
                    fields = new
                    {
                        Front = Encryption.Encrypt(data.Front),
                        Back = Encryption.Encrypt(data.Back)
                    },
                    tags = data.Tags
                };

                notes.Add(card);
            }
            var payload = new
            {
                action = "addNotes",
                @params = new
                {
                    notes = notes
                }
            };

            var response = await SendAnkiRequestAsync(payload);
        }

        public async Task<JArray> GetCardsDetails(List<long> cardIds)
        {
            var payload = new
            {
                action = "cardsInfo",
                @params = new { cards = cardIds }
            };

            var response = await SendAnkiRequestAsync(payload);
            return (JArray)response;
        }

        public async Task<List<long>> FindCards(string deckName, string tags)
        {
            var tagsList = tags.Length > 0
                ? tags.Split(',')
                .Select(x => $"tag:{x}")
                .ToList()
                : null;

            var tagsString = tagsList is not null ? $"({string.Join(" OR ", tagsList)})" : "";

            var payload = new
            {
                action = "findCards",
                @params = new 
                { 
                    query = $"deck:{deckName}" +
                    $"{tagsString} (is:due OR is:new)" 
                }
            };

            var response = await SendAnkiRequestAsync(payload);
            var cardIds = 
                ((JArray)response)
                .Select(x => (long)x)
                .ToList();

            // Return the first card ID, or null if no cards are found
            return cardIds;
        }

        public async Task SubmitReview(long cardId, int ease)
        {
            var payload = new
            {
                action = "answerCards",
                version = 6,
                @params = new
                {
                    answers = new[]
                    {
                        new { cardId, ease }
                    }
                }
            };

            var response = await SendAnkiRequestAsync(payload);
        }
    }
}
