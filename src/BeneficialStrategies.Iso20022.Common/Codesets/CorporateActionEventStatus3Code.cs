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
[IsoId("_bESK0tp-Ed-ak6NoX_4Aeg_2065210906")]
[Description(@"Specifies the status of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionEventStatus3Code>))]
#endif
public enum CorporateActionEventStatus3Code
{
    /// <summary>
    /// The CA event is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bESK09p-Ed-ak6NoX_4Aeg_2065210908")]
    [Description(@"The CA event is cancelled.")]
    Cancelled = CorporateActionEventStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_bESK1Np-Ed-ak6NoX_4Aeg_2065210936")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, eg, expired option."
    )]
    Inactive = CorporateActionEventStatusCode.Inactive, // same ordinal as derivation source for type conversions
}
