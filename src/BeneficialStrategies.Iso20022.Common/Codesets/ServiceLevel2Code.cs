// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKjCAdp-Ed-ak6NoX_4Aeg_757139681")]
[Description(@"Specifies the pre-agreed level of service between the parties.")]
[DerivedFrom(typeof(ServiceLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ServiceLevel2Code>))]
#endif
public enum ServiceLevel2Code
{
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_ZKjCAtp-Ed-ak6NoX_4Aeg_757139776")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea = ServiceLevelCode.SingleEuroPaymentsArea, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// Encoded/decoded by serializers as &quot;SDVA&quot;.
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_ZKjCA9p-Ed-ak6NoX_4Aeg_757140285")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SameDayValue = ServiceLevelCode.SameDayValue, // same ordinal as derivation source for type conversions
}
