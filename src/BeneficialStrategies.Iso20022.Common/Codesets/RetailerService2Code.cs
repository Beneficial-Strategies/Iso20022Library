// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for ServiceRequest
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LlmtUNuREeiB5uLfkg9ZJA")]
[Description(@"List of specific services for ServiceRequest")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService2Code
{
    /// <summary>
    /// The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSPQ")]
    [IsoId("_O3O2IduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System to perform a payment(Purchase/Refund/PWCB/MOTO Payment/...)."
    )]
    FinancialPaymentRequest = RetailerServiceCode.FinancialPaymentRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service.
    /// Encoded/decoded by serializers as &quot;FSRQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSRQ")]
    [IsoId("_PqSqwduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System to perform a reversal partial or complete to cancel a former payment service."
    )]
    FinancialReversalRequest = RetailerServiceCode.FinancialReversalRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to perform balance inquiry on the main account.
    /// Encoded/decoded by serializers as &quot;FSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSIQ")]
    [IsoId("_RAOi8duREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System to perform balance inquiry on the main account."
    )]
    FinancialBalanceInquiryRequest = RetailerServiceCode.FinancialBalanceInquiryRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery).
    /// Encoded/decoded by serializers as &quot;FSBQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSBQ")]
    [IsoId("_R-MnEduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Batch message pair is used to request or get the result of transactions (payment, loyalty and reversal) performed without connection to the Sale system (Payment delivery)."
    )]
    FinancialBatchRequest = RetailerServiceCode.FinancialBatchRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System a loyalty service like loading or redeem.
    /// Encoded/decoded by serializers as &quot;FSLQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSLQ")]
    [IsoId("_TB44sduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System a loyalty service like loading or redeem."
    )]
    FinancialLoyaltyRequest = RetailerServiceCode.FinancialLoyaltyRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement).
    /// Encoded/decoded by serializers as &quot;FSVQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSVQ")]
    [IsoId("_TuL-AduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System to manage a stored value card or account (eg. Load, Payment, Reimbursement)."
    )]
    FinancialStoredValueRequest = RetailerServiceCode.FinancialStoredValueRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to enable a service on its side.
    /// Encoded/decoded by serializers as &quot;FSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSEQ")]
    [IsoId("_UMlKMduREeiB5uLfkg9ZJA")]
    [Description(@"The Sale System requests to the POI System to enable a service on its side.")]
    FinancialEnableServiceRequest = RetailerServiceCode.FinancialEnableServiceRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests to the POI System to handle a card data acquisition on the card reader.
    /// Encoded/decoded by serializers as &quot;FSAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSAQ")]
    [IsoId("_UsbH4duREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System requests to the POI System to handle a card data acquisition on the card reader."
    )]
    FinancialCardAcquisitionRequest = RetailerServiceCode.FinancialCardAcquisitionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System request to the POI System different kinds of transaction reconciliation.
    /// Encoded/decoded by serializers as &quot;FSCQ&quot;.
    /// </summary>
    [EnumMember(Value = "FSCQ")]
    [IsoId("_Va1tEduREeiB5uLfkg9ZJA")]
    [Description(
        @"The Sale System request to the POI System different kinds of transaction reconciliation. "
    )]
    FinancialReconciliationRequest = RetailerServiceCode.FinancialReconciliationRequest, // same ordinal as derivation source for type conversions
}
