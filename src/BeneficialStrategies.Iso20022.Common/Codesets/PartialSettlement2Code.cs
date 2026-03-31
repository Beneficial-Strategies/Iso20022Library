// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_POj5gEAuEeGeCKosDOIVvQ_1172446650")]
[Description(@"Information about partial settlement.")]
[DerivedFrom(typeof(PartialSettlementV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartialSettlement2Code>))]
#endif
public enum PartialSettlement2Code
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_POj5gUAuEeGeCKosDOIVvQ_-493303667")]
    [Description(
        @"Confirmation is for partial settlement. Part of the transaction remains unsettled."
    )]
    PartialSettlement = PartialSettlementV2Code.PartialSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is for partial settlement. No additional settlement will take place.
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_POtDcEAuEeGeCKosDOIVvQ_-607142733")]
    [Description(
        @"Confirmation is for partial settlement. No additional settlement will take place."
    )]
    PartiallyConfirmed = PartialSettlementV2Code.PartiallyConfirmed, // same ordinal as derivation source for type conversions
}
