// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEJA4dp-Ed-ak6NoX_4Aeg_2009797754")]
[Description(@"Specifies the status of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventStatus1Code>))]
#endif
public enum CorporateActionEventStatus1Code
{
    /// <summary>
    /// The CA event is active.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_bEJA4tp-Ed-ak6NoX_4Aeg_2009797756")]
    [Description(@"The CA event is active.")]
    Active = CorporateActionEventStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The CA event is deactivated. The clients cannot send instruction anymore.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_bEJA49p-Ed-ak6NoX_4Aeg_2009797785")]
    [Description(@"The CA event is deactivated. The clients cannot send instruction anymore.")]
    Deactivated = CorporateActionEventStatusCode.Deactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The CA event is expired, no more processing, claims, transformations take place.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_bEJA5Np-Ed-ak6NoX_4Aeg_2009797786")]
    [Description(
        @"The CA event is expired, no more processing, claims, transformations take place."
    )]
    Expired = CorporateActionEventStatusCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The CA event is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bEJA5dp-Ed-ak6NoX_4Aeg_2009797815")]
    [Description(@"The CA event is cancelled.")]
    Cancelled = CorporateActionEventStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The CA event is withrawn, ie, cancelled by the market.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bEJA5tp-Ed-ak6NoX_4Aeg_2009797846")]
    [Description(@"The CA event is withrawn, ie, cancelled by the market.")]
    Withdrawn = CorporateActionEventStatusCode.Withdrawn, // same ordinal as derivation source for type conversions
}
