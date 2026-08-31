// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RequestToPayDebtorActivation.Demo.Persistence;

/// <summary>
/// EF Core value converters for the saga state's nested ISO 20022 record/choice/enum properties
/// (<c>Debtor</c>, <c>Creditor</c>, <c>EffectiveActivationDate</c>, etc.).
/// </summary>
/// <remarks>
/// SIMULATING: this is the same decision a real integration has to make for any ISO 20022 field
/// that doesn't map cleanly onto a flat relational column — party identifications, polymorphic
/// choice types, and spec-governed enums are all structured data, not scalars. Rather than fan
/// each one out into an owned-entity relational graph (awkward for the abstract/polymorphic
/// choice types, and orthogonal to what this demo is illustrating), each is persisted as a JSON
/// column using <see cref="Iso20022JsonSerializerOptions.Default"/> — the EXACT SAME serializer
/// options this library uses for real wire JSON payloads. What lands in MySQL is therefore
/// byte-for-byte the same serialization contract the library ships, not an ad hoc demo shortcut.
/// </remarks>
internal static class Iso20022JsonValueConverter
{
    /// <summary>For reference-typed (record) ISO properties, e.g. <c>RTPPartyIdentification2?</c>.</summary>
    public static ValueConverter<T?, string?> ForClass<T>()
        where T : class =>
        new(
            model => model == null ? null : JsonSerializer.Serialize(model, Iso20022JsonSerializerOptions.Default),
            json => json == null ? null : JsonSerializer.Deserialize<T>(json, Iso20022JsonSerializerOptions.Default)
        );

    /// <summary>For nullable-struct ISO properties, e.g. <c>ServiceRequestStatus1Code?</c>.</summary>
    public static ValueConverter<T?, string?> ForStruct<T>()
        where T : struct =>
        new(
            model =>
                model == null ? null : JsonSerializer.Serialize(model.Value, Iso20022JsonSerializerOptions.Default),
            json => json == null ? null : JsonSerializer.Deserialize<T>(json, Iso20022JsonSerializerOptions.Default)
        );
}
