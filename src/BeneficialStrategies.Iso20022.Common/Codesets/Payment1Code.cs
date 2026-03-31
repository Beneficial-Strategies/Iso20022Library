// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707")]
[Description(@"Specifies the type of payment.")]
[DerivedFrom(typeof(PaymentCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Payment1Code>))]
#endif
public enum Payment1Code
{
    /// <summary>
    /// The cash payment occurs or will occur upon receipt of proceeds from the issuer.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Zy7Qp9p-Ed-ak6NoX_4Aeg_1133077747")]
    [Description(
        @"The cash payment occurs or will occur upon receipt of proceeds from the issuer."
    )]
    ActualPayment = PaymentCode.ActualPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_Zy7QqNp-Ed-ak6NoX_4Aeg_1133077769")]
    [Description(
        @"The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer."
    )]
    ContractualPayment = PaymentCode.ContractualPayment, // same ordinal as derivation source for type conversions
}
