using Serilog;
using System.Text.Json;

namespace MachineLearningApplication_Build_2.Services
{
    public class JSONUnpackingService
    {
        private string ReadJsonContent(string filePath)
        {
            try {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex) {
                Log.Information($"SYSTEM ERROR -> Error reading JSON Text Content : {ex}");
                return string.Empty;
            }
        }

        public T UnpackTextContent<T>(string filePath) where T : class, new()
        {
            try
            {
                string JSONContent = ReadJsonContent(filePath);
                return JsonSerializer.Deserialize<T>(JSONContent) ?? new T();
            }
            catch (JsonException ex)
            {
                Log.Information($"SYSTEM ERROR -> Error Deserializing JSON content : {ex}");
                return new T();

            }
        
        
        }
    }
}
