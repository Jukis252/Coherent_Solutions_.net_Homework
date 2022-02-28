using System.Reflection;
using System.Text.Json;

namespace Attributes;

public class Logger
{
    public Logger(string fileName)
    {
        FileName = fileName;
    }

    public string FileName { get; }

    public void Track(object obj)

    {
        var objTracked = new Dictionary<string, string?>();

        if (obj.GetType().GetCustomAttribute<TrackingEntity>() != null)
        {
            foreach (var fieldInfo in obj.GetType().GetFields().Where(p => p.GetCustomAttribute<TrackingProperty>() != null))
            {
                var fieldName = fieldInfo.GetCustomAttribute<TrackingProperty>()?.PropertyName ?? fieldInfo.Name;

                objTracked.Add(fieldName, fieldInfo.GetValue(obj)?.ToString());
            }

            foreach (var propertyInfo in obj.GetType().GetProperties().Where(p => p.GetCustomAttribute<TrackingProperty>() != null))
            {
                var propertyName = propertyInfo.GetCustomAttribute<TrackingProperty>()?.PropertyName ?? propertyInfo.Name;

                objTracked.Add(propertyName, propertyInfo.GetValue(obj)?.ToString());
            }

            var fileName = $"{FileName}.json";
            var jsonString = JsonSerializer.Serialize(objTracked);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
