// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that an order is pegged against the offer/bid at the time of the order submission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQpqANp-Ed-ak6NoX_4Aeg_1097083970")]
[Description(
    @"Indicates that an order is pegged against the offer/bid at the time of the order submission."
)]
[Derivations(typeof(StayOnSideType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StayOnSideTypeCode>))]
#endif
public enum StayOnSideTypeCode
{
    /// <summary>
    /// An order pegged against the offer price.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_ZQpqAdp-Ed-ak6NoX_4Aeg_1520979426")]
    [Description(@"An order pegged against the offer price.")]
    Offer,

    /// <summary>
    /// An order pegged against the bid price.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_ZQpqAtp-Ed-ak6NoX_4Aeg_1525594701")]
    [Description(@"An order pegged against the bid price.")]
    Bid,

    /// <summary>
    /// Indicates a voluntary absence of choice/decision.
    /// Encoded/decoded by serializers as &quot;DCAR&quot;.
    /// </summary>
    [EnumMember(Value = "DCAR")]
    [IsoId("_ZQpqA9p-Ed-ak6NoX_4Aeg_1547762094")]
    [Description(@"Indicates a voluntary absence of choice/decision.")]
    DontCare,
}
