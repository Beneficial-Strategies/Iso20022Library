// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Strong customer authentication exemption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JK8y8Ax1Eeqdx6buGpCCQw")]
[Description(@"Strong customer authentication exemption.")]
[DerivedFrom(typeof(ExemptionCode))]
public enum Exemption1Code
{
    /// <summary>
    /// Transaction&apos;s amount is low and could be processed without strong customer authentication.
    /// Encoded/decoded by serializers as &quot;LOWA&quot;.
    /// </summary>
    [EnumMember(Value = "LOWA")]
    [IsoId("_PN0UUQx1Eeqdx6buGpCCQw")]
    [Description(
        @"Transaction's amount is low and could be processed without strong customer authentication."
    )]
    LowAmountExemption = ExemptionCode.LowAmountExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is initiated by the Card Acceptor.
    /// Encoded/decoded by serializers as &quot;MINT&quot;.
    /// </summary>
    [EnumMember(Value = "MINT")]
    [IsoId("_PR5jEQx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is initiated by the Card Acceptor.")]
    MerchantInitiatedTransaction = ExemptionCode.MerchantInitiatedTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is one of a series of recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_PV2O8Qx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is one of a series of recurring payment.")]
    RecurringPayment = ExemptionCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a secure corporate payment.
    /// Encoded/decoded by serializers as &quot;SCPE&quot;.
    /// </summary>
    [EnumMember(Value = "SCPE")]
    [IsoId("_PZupYQx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is a secure corporate payment.")]
    SecureCorporatePaymentExemption = ExemptionCode.SecureCorporatePaymentExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card Acceptor is a strong customer authentication delegate.
    /// Encoded/decoded by serializers as &quot;SCAD&quot;.
    /// </summary>
    [EnumMember(Value = "SCAD")]
    [IsoId("_PdoR8Qx1Eeqdx6buGpCCQw")]
    [Description(@"Card Acceptor is a strong customer authentication delegate.")]
    StrongCustomerAuthenticationDelegation = ExemptionCode.StrongCustomerAuthenticationDelegation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// According to the transaction risk analysis the strong customer authentication is not mandated.
    /// Encoded/decoded by serializers as &quot;TRAE&quot;.
    /// </summary>
    [EnumMember(Value = "TRAE")]
    [IsoId("_PhGcsQx1Eeqdx6buGpCCQw")]
    [Description(
        @"According to the transaction risk analysis the strong customer authentication is not mandated."
    )]
    TransactionRiskAnalysisExemption = ExemptionCode.TransactionRiskAnalysisExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is processed in a environment where strong customer authentication is inappropriate.
    /// Encoded/decoded by serializers as &quot;PKGE&quot;.
    /// </summary>
    [EnumMember(Value = "PKGE")]
    [IsoId("_Pkpf8Qx1Eeqdx6buGpCCQw")]
    [Description(
        @"Payment is processed in a environment where strong customer authentication is inappropriate."
    )]
    TransportFareOrParkingFeeUnattendedPaymentExemption =
        ExemptionCode.TransportFareOrParkingFeeUnattendedPaymentExemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.
    /// Encoded/decoded by serializers as &quot;TMBE&quot;.
    /// </summary>
    [EnumMember(Value = "TMBE")]
    [IsoId("_PolkwQx1Eeqdx6buGpCCQw")]
    [Description(
        @"Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication."
    )]
    TrustedMerchantBeneficiaryExemption = ExemptionCode.TrustedMerchantBeneficiaryExemption, // same ordinal as derivation source for type conversions
}
