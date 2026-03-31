// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-qqGELXOEeiTob_PrFFUxA")]
[Description(
    @"Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer."
)]
[DerivedFrom(typeof(PaymentCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Payment2Code>))]
#endif
public enum Payment2Code
{
    /// <summary>
    /// The cash payment occurs or will occur upon receipt of proceeds from the issuer.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_KIs2sbXPEeiTob_PrFFUxA")]
    [Description(
        @"The cash payment occurs or will occur upon receipt of proceeds from the issuer."
    )]
    ActualPayment = PaymentCode.ActualPayment, // same ordinal as derivation source for type conversions
}
