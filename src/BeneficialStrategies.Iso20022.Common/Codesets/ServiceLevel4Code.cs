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
[IsoId("_ZKjCBNp-Ed-ak6NoX_4Aeg_918510660")]
[Description(@"Specifies the pre-agreed level of service between the parties.")]
[DerivedFrom(typeof(ServiceLevelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ServiceLevel4Code>))]
#endif
public enum ServiceLevel4Code
{
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_ZKjCBdp-Ed-ak6NoX_4Aeg_918510723")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea = ServiceLevelCode.SingleEuroPaymentsArea, // same ordinal as derivation source for type conversions
}
