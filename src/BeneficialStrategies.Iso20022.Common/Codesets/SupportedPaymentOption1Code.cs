// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-6mVcDANEeOqioR9srQH1g")]
[Description(@"Specifies the options supported for a payment transaction.")]
[DerivedFrom(typeof(SupportedPaymentOptionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SupportedPaymentOption1Code>))]
#endif
public enum SupportedPaymentOption1Code
{
    /// <summary>
    /// The entity supports a partial approval of the payment transaction.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Aa2nQTAOEeOqioR9srQH1g")]
    [Description(@"The entity supports a partial approval of the payment transaction.")]
    PartialApproval = SupportedPaymentOptionCode.PartialApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).
    /// Encoded/decoded by serializers as &quot;MSRV&quot;.
    /// </summary>
    [EnumMember(Value = "MSRV")]
    [IsoId("_Am5fMzAOEeOqioR9srQH1g")]
    [Description(
        @"The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back)."
    )]
    PaymentApprovalOnly = SupportedPaymentOptionCode.PaymentApprovalOnly, // same ordinal as derivation source for type conversions
}
