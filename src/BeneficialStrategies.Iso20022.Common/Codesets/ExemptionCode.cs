// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of  available exemption codes to strong customer authentication.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_g7FHoAxyEeqdx6buGpCCQw")]
[Description(@"List of  available exemption codes to strong customer authentication.")]
[Derivations(typeof(Exemption1Code), typeof(Exemption2Code))]
public enum ExemptionCode
{
    /// <summary>
    /// Transaction is initiated by the Card Acceptor.
    /// Encoded/decoded by serializers as &quot;MINT&quot;.
    /// </summary>
    [EnumMember(Value = "MINT")]
    [IsoId("_1Ma54AxyEeqdx6buGpCCQw")]
    [Description(@"Transaction is initiated by the Card Acceptor.")]
    MerchantInitiatedTransaction,

    /// <summary>
    /// Transaction is one of a series of recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_ElVkoAxzEeqdx6buGpCCQw")]
    [Description(@"Transaction is one of a series of recurring payment.")]
    RecurringPayment,

    /// <summary>
    /// Transaction&apos;s amount is low and could be processed without strong customer authentication.
    /// Encoded/decoded by serializers as &quot;LOWA&quot;.
    /// </summary>
    [EnumMember(Value = "LOWA")]
    [IsoId("_MlRPoAxzEeqdx6buGpCCQw")]
    [Description(
        @"Transaction's amount is low and could be processed without strong customer authentication."
    )]
    LowAmountExemption,

    /// <summary>
    /// According to the transaction risk analysis the strong customer authentication is not mandated.
    /// Encoded/decoded by serializers as &quot;TRAE&quot;.
    /// </summary>
    [EnumMember(Value = "TRAE")]
    [IsoId("_eBX6IAxzEeqdx6buGpCCQw")]
    [Description(
        @"According to the transaction risk analysis the strong customer authentication is not mandated."
    )]
    TransactionRiskAnalysisExemption,

    /// <summary>
    /// Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.
    /// Encoded/decoded by serializers as &quot;TMBE&quot;.
    /// </summary>
    [EnumMember(Value = "TMBE")]
    [IsoId("_Oi6yoAx0Eeqdx6buGpCCQw")]
    [Description(
        @"Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication."
    )]
    TrustedMerchantBeneficiaryExemption,

    /// <summary>
    /// Card Acceptor is a strong customer authentication delegate.
    /// Encoded/decoded by serializers as &quot;SCAD&quot;.
    /// </summary>
    [EnumMember(Value = "SCAD")]
    [IsoId("_fu2TIAx0Eeqdx6buGpCCQw")]
    [Description(@"Card Acceptor is a strong customer authentication delegate.")]
    StrongCustomerAuthenticationDelegation,

    /// <summary>
    /// Transaction is a secure corporate payment.
    /// Encoded/decoded by serializers as &quot;SCPE&quot;.
    /// </summary>
    [EnumMember(Value = "SCPE")]
    [IsoId("_zgt7IAx0Eeqdx6buGpCCQw")]
    [Description(@"Transaction is a secure corporate payment.")]
    SecureCorporatePaymentExemption,

    /// <summary>
    /// Payment is processed in a environment where strong customer authentication is inappropriate.
    /// Encoded/decoded by serializers as &quot;PKGE&quot;.
    /// </summary>
    [EnumMember(Value = "PKGE")]
    [IsoId("_9fmmIAx0Eeqdx6buGpCCQw")]
    [Description(
        @"Payment is processed in a environment where strong customer authentication is inappropriate."
    )]
    TransportFareOrParkingFeeUnattendedPaymentExemption,

    /// <summary>
    /// Payment account information exemption.
    /// Encoded/decoded by serializers as &quot;PAAC&quot;.
    /// </summary>
    [EnumMember(Value = "PAAC")]
    [IsoId("_QyrHkBkqEeuGbrXbitsqoQ")]
    [Description(@"Payment account information exemption.")]
    PaymentAccountExemption,

    /// <summary>
    /// Contactless payment at point of sale exemption.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_WB3wUBkqEeuGbrXbitsqoQ")]
    [Description(@"Contactless payment at point of sale exemption.")]
    ContactlessExemption,

    /// <summary>
    /// Credit transfer between accounts held by the same natural or legal person exemption.
    /// Encoded/decoded by serializers as &quot;TRSP&quot;.
    /// </summary>
    [EnumMember(Value = "TRSP")]
    [IsoId("_b6RHEBkqEeuGbrXbitsqoQ")]
    [Description(
        @"Credit transfer between accounts held by the same natural or legal person exemption."
    )]
    TransferSamePersonExemption,
}
