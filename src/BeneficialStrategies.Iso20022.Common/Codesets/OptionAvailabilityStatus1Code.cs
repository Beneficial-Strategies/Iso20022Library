// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the option availability.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPPZNtp-Ed-ak6NoX_4Aeg_2092234536")]
[Description(@"Specifies the status of the option availability.")]
[DerivedFrom(typeof(OptionAvailabilityStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionAvailabilityStatus1Code>))]
#endif
public enum OptionAvailabilityStatus1Code
{
    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_aPPZN9p-Ed-ak6NoX_4Aeg_-1302299836")]
    [Description(
        @"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option."
    )]
    Inactive = OptionAvailabilityStatusCode.Inactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aPPZONp-Ed-ak6NoX_4Aeg_-1302299783")]
    [Description(
        @"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required."
    )]
    Cancelled = OptionAvailabilityStatusCode.Cancelled, // same ordinal as derivation source for type conversions
}
