// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the CA option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEJA59p-Ed-ak6NoX_4Aeg_2035657818")]
[Description(@"Specifies the status of the CA option.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventStatus2Code>))]
#endif
public enum CorporateActionEventStatus2Code
{
    /// <summary>
    /// The CA event is active.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_bEJA6Np-Ed-ak6NoX_4Aeg_2035657828")]
    [Description(@"The CA event is active.")]
    Active = CorporateActionEventStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The CA event is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bESK0Np-Ed-ak6NoX_4Aeg_2035657849")]
    [Description(@"The CA event is cancelled.")]
    Cancelled = CorporateActionEventStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_bESK0dp-Ed-ak6NoX_4Aeg_2035657858")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option."
    )]
    Inactive = CorporateActionEventStatusCode.Inactive, // same ordinal as derivation source for type conversions
}
