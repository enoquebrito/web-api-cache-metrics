namespace CacheWebAPI.Infra.ExtensionMethods;

public static class EntityTransformationExtension
{
    public static T TransformTo<T>(this ITransformable source) where T : new()
    {
        var sourceProperties = source.GetType().GetProperties();
        var targetType = typeof(T);
        var targetEntity = new T();
        
        foreach (var property in sourceProperties)
        {
            var targetProperty = targetType.GetProperty(property.Name);

            if (targetProperty is null || !targetProperty.CanWrite)
            {
                continue;
            }
            
            var value = property.GetValue(source);
            targetProperty.SetValue(targetEntity, value);
        }

        return targetEntity;
    }
}

public interface ITransformable;
