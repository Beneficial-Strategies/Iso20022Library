// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// <see cref="JsonConverterFactory"/> that handles all ISO 20022 enum types, reading
/// <see cref="EnumMemberAttribute"/> to produce the correct ISO wire code string (e.g.
/// <c>"CHEC"</c>) rather than the C# member name.
/// </summary>
/// <remarks>
/// Register in <see cref="JsonSerializerOptions"/> as a fallback for enums that do not
/// carry a type-level <see cref="JsonConverterAttribute"/>:
/// <code>
/// options.Converters.Add(Iso20022EnumConverterFactory.Instance);
/// </code>
/// For enums that do carry <c>[JsonConverter(typeof(Iso20022EnumJsonConverter&lt;T&gt;))]</c>
/// the attribute takes precedence and this factory is not consulted.
/// </remarks>
public sealed class Iso20022EnumConverterFactory : JsonConverterFactory
{
    /// <summary>Singleton — stateless, safe to share.</summary>
    public static readonly Iso20022EnumConverterFactory Instance = new();

    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsEnum;

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(Iso20022EnumJsonConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}

/// <summary>
/// Reads and writes an ISO 20022 enum value using the <see cref="EnumMemberAttribute"/>
/// wire code (e.g. <c>"CHEC"</c>) rather than the C# member name.
/// </summary>
/// <typeparam name="T">The enum type.</typeparam>
public sealed class Iso20022EnumJsonConverter<T> : JsonConverter<T>
    where T : struct, Enum
{
    private static readonly Dictionary<T, string> s_toWire;
    private static readonly Dictionary<string, T> s_fromWire;

    static Iso20022EnumJsonConverter()
    {
        var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static);
        s_toWire = new Dictionary<T, string>(fields.Length);
        s_fromWire = new Dictionary<string, T>(fields.Length, StringComparer.Ordinal);

        foreach (var field in fields)
        {
            var value = (T)field.GetValue(null)!;
            var wire = field.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? field.Name;
            s_toWire[value] = wire;
            s_fromWire[wire] = value;
        }
    }

    /// <inheritdoc/>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        if (str is not null && s_fromWire.TryGetValue(str, out var value))
            return value;
        throw new JsonException($"Unknown {typeof(T).Name} value: '{str}'");
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (s_toWire.TryGetValue(value, out var wire))
            writer.WriteStringValue(wire);
        else
            throw new JsonException($"Cannot serialize {typeof(T).Name} value {value}.");
    }
}
