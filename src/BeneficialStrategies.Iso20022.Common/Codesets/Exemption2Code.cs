// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Strong customer authentication exemption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0UIoMAMhEeujMs2LsB3mMw")]
[Description(@"Strong customer authentication exemption.")]
[DerivedFrom(typeof(ExemptionCode))]
public enum Exemption2Code
{
    /// <summary>
    /// Payment is processed in a environment where strong customer authentication is inappropriate.
    /// Encoded/decoded by serializers as &quot;PKGE&quot;.
    /// </summary>
    [EnumMember(Value = "PKGE")]
    [IsoId("_8TKpYQMjEeujMs2LsB3mMw")]
    [Description(@"Payment is processed in a environment where strong customer authentication is inappropriate.")]
    TransportFareOrParkingFeeUnattendedPaymentExemption = ExemptionCode.TransportFareOrParkingFeeUnattendedPaymentExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.
    /// Encoded/decoded by serializers as &quot;TMBE&quot;.
    /// </summary>
    [EnumMember(Value = "TMBE")]
    [IsoId("_87kGIQMjEeujMs2LsB3mMw")]
    [Description(@"Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.")]
    TrustedMerchantBeneficiaryExemption = ExemptionCode.TrustedMerchantBeneficiaryExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is one of a series of recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_9rAmEQMjEeujMs2LsB3mMw")]
    [Description(@"Transaction is one of a series of recurring payment.")]
    RecurringPayment = ExemptionCode.RecurringPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction&apos;s amount is low and could be processed without strong customer authentication.
    /// Encoded/decoded by serializers as &quot;LOWA&quot;.
    /// </summary>
    [EnumMember(Value = "LOWA")]
    [IsoId("__qDFoQMjEeujMs2LsB3mMw")]
    [Description(@"Transaction's amount is low and could be processed without strong customer authentication.")]
    LowAmountExemption = ExemptionCode.LowAmountExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a secure corporate payment.
    /// Encoded/decoded by serializers as &quot;SCPE&quot;.
    /// </summary>
    [EnumMember(Value = "SCPE")]
    [IsoId("_BmPFgQMkEeujMs2LsB3mMw")]
    [Description(@"Transaction is a secure corporate payment.")]
    SecureCorporatePaymentExemption = ExemptionCode.SecureCorporatePaymentExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// According to the transaction risk analysis the strong customer authentication is not mandated.
    /// Encoded/decoded by serializers as &quot;TRAE&quot;.
    /// </summary>
    [EnumMember(Value = "TRAE")]
    [IsoId("_CKDkQQMkEeujMs2LsB3mMw")]
    [Description(@"According to the transaction risk analysis the strong customer authentication is not mandated.")]
    TransactionRiskAnalysisExemption = ExemptionCode.TransactionRiskAnalysisExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless payment at point of sale exemption.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_qE6A0RkqEeuGbrXbitsqoQ")]
    [Description(@"Contactless payment at point of sale exemption.")]
    ContactlessExemption = ExemptionCode.ContactlessExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment account information exemption.
    /// Encoded/decoded by serializers as &quot;PAAC&quot;.
    /// </summary>
    [EnumMember(Value = "PAAC")]
    [IsoId("_rXxW4RkqEeuGbrXbitsqoQ")]
    [Description(@"Payment account information exemption.")]
    PaymentAccountExemption = ExemptionCode.PaymentAccountExemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer between accounts held by the same natural or legal person exemption.
    /// Encoded/decoded by serializers as &quot;TRSP&quot;.
    /// </summary>
    [EnumMember(Value = "TRSP")]
    [IsoId("_svszIRkqEeuGbrXbitsqoQ")]
    [Description(@"Credit transfer between accounts held by the same natural or legal person exemption.")]
    TransferSamePersonExemption = ExemptionCode.TransferSamePersonExemption, // same ordinal as derivation source for type conversions
    
}
