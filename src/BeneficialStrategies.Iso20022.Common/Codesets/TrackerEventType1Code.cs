// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of payment event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wQDn0HlAEei6J5_ka3EtUg")]
[Description(@"Indicates the type of payment event.")]
[DerivedFrom(typeof(TrackerEventTypeCode))]
public enum TrackerEventType1Code
{
    /// <summary>
    /// Indicates a cover payment.
    /// Encoded/decoded by serializers as &quot;COPT&quot;.
    /// </summary>
    [EnumMember(Value = "COPT")]
    [IsoId("_itKQkYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cover payment.")]
    CoverPayment = TrackerEventTypeCode.CoverPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a customer credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTPT&quot;.
    /// </summary>
    [EnumMember(Value = "CTPT")]
    [IsoId("_i4nSoYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a customer credit transfer payment.")]
    CustomerCreditTransferPayment = TrackerEventTypeCode.CustomerCreditTransferPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTCA&quot;.
    /// </summary>
    [EnumMember(Value = "CTCA")]
    [IsoId("_jAWSUYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequest = TrackerEventTypeCode.CreditTransferPaymentCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the tracking status of a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTTS&quot;.
    /// </summary>
    [EnumMember(Value = "CTTS")]
    [IsoId("_jIh98YaTEeiMm4lwapNmDA")]
    [Description(@"Indicates the tracking status of a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequestTrackingStatus = TrackerEventTypeCode.CreditTransferPaymentCancellationRequestTrackingStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a cancellation response related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTCR&quot;.
    /// </summary>
    [EnumMember(Value = "CTCR")]
    [IsoId("_jPrHwYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cancellation response related to a credit transfer payment.")]
    CreditTransferPaymentCancellationResponse = TrackerEventTypeCode.CreditTransferPaymentCancellationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a cover payment status update.
    /// Encoded/decoded by serializers as &quot;COSU&quot;.
    /// </summary>
    [EnumMember(Value = "COSU")]
    [IsoId("_jWN0oYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cover payment status update.")]
    StatusUpdateCoverPayment = TrackerEventTypeCode.StatusUpdateCoverPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a customer credit transfer payment status update.
    /// Encoded/decoded by serializers as &quot;CTSU&quot;.
    /// </summary>
    [EnumMember(Value = "CTSU")]
    [IsoId("_jdzqYYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a customer credit transfer payment status update.")]
    StatusUpdateCustomerCreditTransferPayment = TrackerEventTypeCode.StatusUpdateCustomerCreditTransferPayment, // same ordinal as derivation source for type conversions
    
}
