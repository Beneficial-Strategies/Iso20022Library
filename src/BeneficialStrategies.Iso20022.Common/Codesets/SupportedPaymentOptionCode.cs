// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UdiH4DANEeOqioR9srQH1g")]
[Description(@"Specifies the options supported for a payment transaction.")]
[Derivations(typeof(SupportedPaymentOption1Code), typeof(SupportedPaymentOption2Code))]
public enum SupportedPaymentOptionCode
{
    /// <summary>
    /// The entity supports a partial approval of the payment transaction.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_mVwtsDANEeOqioR9srQH1g")]
    [Description(@"The entity supports a partial approval of the payment transaction.")]
    PartialApproval,

    /// <summary>
    /// The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back).
    /// Encoded/decoded by serializers as &quot;MSRV&quot;.
    /// </summary>
    [EnumMember(Value = "MSRV")]
    [IsoId("_s2B8wDANEeOqioR9srQH1g")]
    [Description(
        @"The entity supports the approval of the payment service along with the decline of additional requested services (as cash-back)."
    )]
    PaymentApprovalOnly,

    /// <summary>
    /// The sender support IssuerInstalment proposals to the Cardholder.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_PfI_YE7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender support IssuerInstalment proposals to the Cardholder.")]
    IssuerInstalment,

    /// <summary>
    /// The sender is able to support Single Tap transaction.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_UM9ZYE7GEeyGi9JAv6wq7Q")]
    [Description(@"The sender is able to support Single Tap transaction.")]
    PINRequest,
}
