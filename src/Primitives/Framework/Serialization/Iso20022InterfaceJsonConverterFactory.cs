// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes the interfaces of the model (messages, components, choices and their variants) as JSON, in the same shape the
/// records have: the names come from the options' naming policy, a list is an array, and a choice is an object with a
/// <c>$type</c> naming its variant. The objects read are made by an <see cref="IIsoDataFactory"/>.
/// </summary>
/// <remarks>
/// Add one instance to <see cref="JsonSerializerOptions.Converters"/> next to the converters of
/// <see cref="Iso20022JsonSerializerOptions"/>. A property declared with an interface then reads into whatever the factory makes
/// for it, so an event type can say <c>IGroupHeader131</c> and need not reference the records.
/// </remarks>
public sealed class Iso20022InterfaceJsonConverterFactory(IIsoDataFactory factory) : JsonConverterFactory
{
    private const string Discriminator = "$type";

    private readonly IIsoDataFactory _factory = factory ?? throw new System.ArgumentNullException(nameof(factory));

    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert.IsInterface && Iso.KindOf(typeToConvert) is IsoKind.Message or IsoKind.Component or IsoKind.Choice or IsoKind.ChoiceVariant;

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) =>
        (JsonConverter)Activator.CreateInstance(typeof(InterfaceConverter<>).MakeGenericType(typeToConvert), _factory)!;

    private sealed class InterfaceConverter<T>(IIsoDataFactory factory) : JsonConverter<T>
        where T : class
    {
        private static bool IsChoice => Iso.KindOf(typeof(T)) == IsoKind.Choice;

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"Expected a JSON object for {typeof(T).Name}, got {reader.TokenType}.");
            var element = JsonElement.ParseValue(ref reader);

            var type = typeof(T);
            if (IsChoice)
            {
                if (!element.TryGetProperty(Discriminator, out var tag) || tag.ValueKind != JsonValueKind.String)
                    throw new JsonException($"{type.Name} is a choice: the object needs a \"{Discriminator}\" naming its variant.");
                var name = tag.GetString()!;
                type = Variants(type).FirstOrDefault(v => v.Name.Length > 1 && v.Name.AsSpan(1).SequenceEqual(name.AsSpan()))
                    ?? throw new JsonException($"{typeof(T).Name} has no variant '{name}'. Expected one of: {string.Join(", ", Variants(type).Select(v => v.Name[1..]))}.");
            }

            var instance = factory.Create(type);
            foreach (var meta in Iso20022XmlSerializer.GetProps(type))
            {
                var key = Name(meta.Property.Name, options);
                var found = element.TryGetProperty(key, out var json) && json.ValueKind != JsonValueKind.Null;
                if (!found)
                {
                    if (meta.IsCollection)
                        Iso20022XmlSerializer.SetMember(instance, meta, Iso20022XmlSerializer.CreateList(meta.Property.PropertyType, meta.CoreType, []));
                    else if (meta.IsRequired)
                        throw new JsonException($"{type.Name}: the required member '{key}' is missing.");
                    continue;
                }
                try
                {
                    if (meta.IsCollection)
                    {
                        if (json.ValueKind != JsonValueKind.Array)
                            throw new JsonException($"Expected a JSON array, got {json.ValueKind}.");
                        var items = json.EnumerateArray().Select(e => JsonSerializer.Deserialize(e, meta.CoreType, options)!).ToList();
                        Iso20022XmlSerializer.SetMember(instance, meta, Iso20022XmlSerializer.CreateList(meta.Property.PropertyType, meta.CoreType, items));
                    }
                    else
                    {
                        var declared = Nullable.GetUnderlyingType(meta.Property.PropertyType) ?? meta.Property.PropertyType;
                        Iso20022XmlSerializer.SetMember(instance, meta, JsonSerializer.Deserialize(json, declared, options));
                    }
                }
                catch (JsonException ex)
                {
                    throw new JsonException($"{type.Name}.{key}: {ex.Message}", ex);
                }
                catch (Iso20022FormatException ex)
                {
                    throw new JsonException($"{type.Name}.{key}: {ex.Message}", ex);
                }
            }
            return (T)instance;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var type = typeof(T);
            if (IsChoice)
                type = Variants(type).FirstOrDefault(v => v.IsInstanceOfType(value))
                    ?? throw new JsonException($"{value.GetType().Name} is not a variant of {typeof(T).Name}.");

            writer.WriteStartObject();
            if (IsChoice)
                writer.WriteString(Discriminator, type.Name[1..]);
            foreach (var meta in Iso20022XmlSerializer.GetProps(type))
            {
                writer.WritePropertyName(Name(meta.Property.Name, options));
                var member = meta.Property.GetValue(value);
                if (member is null)
                    writer.WriteNullValue();
                else if (meta.IsCollection)
                {
                    writer.WriteStartArray();
                    foreach (var item in (System.Collections.IEnumerable)member)
                        JsonSerializer.Serialize(writer, item, meta.CoreType, options);
                    writer.WriteEndArray();
                }
                else
                    JsonSerializer.Serialize(writer, member, Nullable.GetUnderlyingType(meta.Property.PropertyType) ?? meta.Property.PropertyType, options);
            }
            writer.WriteEndObject();
        }

        private static string Name(string property, JsonSerializerOptions options) => options.PropertyNamingPolicy?.ConvertName(property) ?? property;

        private static IEnumerable<Type> Variants(Type choice) =>
            Iso20022XmlSerializer.VariantInterfaces.GetOrAdd(choice.Assembly, Iso20022XmlSerializer.FindVariantInterfaces)[choice];
    }
}
