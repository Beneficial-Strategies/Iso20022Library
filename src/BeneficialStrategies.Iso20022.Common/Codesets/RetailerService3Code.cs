// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for ServiceResponse.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jfjsINwtEeioifFt1dhnJA")]
[Description(@"List of specific services for ServiceResponse.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService3Code
{
    /// <summary>
    /// The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...).
    /// Encoded/decoded by serializers as &quot;FSPP&quot;.
    /// </summary>
    [EnumMember(Value = "FSPP")]
    [IsoId("_qmFC4dwtEeioifFt1dhnJA")]
    [Description(
        @"The POI System sends a response to a payment request (Purchase/refund/PWCB/MOTO Payment/...)."
    )]
    FinancialPaymentResponse = RetailerServiceCode.FinancialPaymentResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a reversal request.
    /// Encoded/decoded by serializers as &quot;FSRP&quot;.
    /// </summary>
    [EnumMember(Value = "FSRP")]
    [IsoId("_rgA7kdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a reversal request.")]
    FinancialReversalResponse = RetailerServiceCode.FinancialReversalResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a Balance Inquiry request.
    /// Encoded/decoded by serializers as &quot;FSIP&quot;.
    /// </summary>
    [EnumMember(Value = "FSIP")]
    [IsoId("_sPsFAdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a Balance Inquiry request.")]
    FinancialBalanceInquiryResponse = RetailerServiceCode.FinancialBalanceInquiryResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a batch processing request.
    /// Encoded/decoded by serializers as &quot;FSBP&quot;.
    /// </summary>
    [EnumMember(Value = "FSBP")]
    [IsoId("_s3K7wdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a batch processing request.")]
    FinancialBatchResponse = RetailerServiceCode.FinancialBatchResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a loyalty processing request.
    /// Encoded/decoded by serializers as &quot;FSLP&quot;.
    /// </summary>
    [EnumMember(Value = "FSLP")]
    [IsoId("_tcgdcdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a loyalty processing request.")]
    FinancialLoyaltyResponse = RetailerServiceCode.FinancialLoyaltyResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a stored value card or account request.
    /// Encoded/decoded by serializers as &quot;FSVP&quot;.
    /// </summary>
    [EnumMember(Value = "FSVP")]
    [IsoId("_uLJFEdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a stored value card or account request.")]
    FinancialStoredValueResponse = RetailerServiceCode.FinancialStoredValueResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response after enabling or not some service.
    /// Encoded/decoded by serializers as &quot;FSEP&quot;.
    /// </summary>
    [EnumMember(Value = "FSEP")]
    [IsoId("_uvJKAdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response after enabling or not some service.")]
    FinancialEnableServiceResponse = RetailerServiceCode.FinancialEnableServiceResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a card data acquisition request.
    /// Encoded/decoded by serializers as &quot;FSAP&quot;.
    /// </summary>
    [EnumMember(Value = "FSAP")]
    [IsoId("_vRGnkdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a card data acquisition request.")]
    FinancialCardAcquisitionResponse = RetailerServiceCode.FinancialCardAcquisitionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System sends a response to a reconciliation request.
    /// Encoded/decoded by serializers as &quot;FSCP&quot;.
    /// </summary>
    [EnumMember(Value = "FSCP")]
    [IsoId("_wGk3AdwtEeioifFt1dhnJA")]
    [Description(@"The POI System sends a response to a reconciliation request.")]
    FinancialReconciliationResponse = RetailerServiceCode.FinancialReconciliationResponse, // same ordinal as derivation source for type conversions
}
