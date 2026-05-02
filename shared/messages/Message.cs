using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Shared.messages
{
    public static class Message
    {
        private static readonly Lazy<Dictionary<string, Dictionary<string, string>>> _messages =
            new(() =>
            {
                string basePath = AppContext.BaseDirectory; // points to the host bin folder
                string filePath = Path.Combine(basePath, "Resources", "Messages.json");
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Messages.json not found at {filePath}");
                }


                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json)
                       ?? new Dictionary<string, Dictionary<string, string>>();
            });

        public static string Get(MessageCode code)
        {
            string key = code.ToString();
            string language = CultureInfo.CurrentUICulture.Name;
            Dictionary<string, Dictionary<string, string>> messages = _messages.Value;

            if (messages.TryGetValue(key, out Dictionary<string, string> translations)
                && translations.TryGetValue(language, out string message))
            {
                return message;
            }

            return $"Unknown error: {key}";
        }
    }
}
