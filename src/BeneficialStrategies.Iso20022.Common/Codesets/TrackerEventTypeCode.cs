// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of payment event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mPL1QHk_Eei6J5_ka3EtUg")]
[Description(@"Indicates the type of payment event.")]
[Derivations(typeof(TrackerEventType1Code))]
public enum TrackerEventTypeCode
{
    /// <summary>
    /// Indicates a customer credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTPT&quot;.
    /// </summary>
    [EnumMember(Value = "CTPT")]
    [IsoId("_TarX8HlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a customer credit transfer payment.")]
    CustomerCreditTransferPayment,
    
    /// <summary>
    /// Indicates a cover payment.
    /// Encoded/decoded by serializers as &quot;COPT&quot;.
    /// </summary>
    [EnumMember(Value = "COPT")]
    [IsoId("_YorG0HlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a cover payment.")]
    CoverPayment,
    
    /// <summary>
    /// Indicates a customer credit transfer payment status update.
    /// Encoded/decoded by serializers as &quot;CTSU&quot;.
    /// </summary>
    [EnumMember(Value = "CTSU")]
    [IsoId("_eeK6kHlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a customer credit transfer payment status update.")]
    StatusUpdateCustomerCreditTransferPayment,
    
    /// <summary>
    /// Indicates a cover payment status update.
    /// Encoded/decoded by serializers as &quot;COSU&quot;.
    /// </summary>
    [EnumMember(Value = "COSU")]
    [IsoId("_gzhBUHlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a cover payment status update.")]
    StatusUpdateCoverPayment,
    
    /// <summary>
    /// Indicates a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTCA&quot;.
    /// </summary>
    [EnumMember(Value = "CTCA")]
    [IsoId("_lWSo8HlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequest,
    
    /// <summary>
    /// Indicates a cancellation response related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTCR&quot;.
    /// </summary>
    [EnumMember(Value = "CTCR")]
    [IsoId("_nTkN8HlAEei6J5_ka3EtUg")]
    [Description(@"Indicates a cancellation response related to a credit transfer payment.")]
    CreditTransferPaymentCancellationResponse,
    
    /// <summary>
    /// Indicates the tracking status of a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as &quot;CTTS&quot;.
    /// </summary>
    [EnumMember(Value = "CTTS")]
    [IsoId("_Llkj0IEKEeit85CUkZUMaw")]
    [Description(@"Indicates the tracking status of a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequestTrackingStatus,
    
    /// <summary>
    /// Indicates a Financial Institution Credit Transfer Payment.
    /// Encoded/decoded by serializers as &quot;FTPT&quot;.
    /// </summary>
    [EnumMember(Value = "FTPT")]
    [IsoId("_cWMD8FnoEemOfpP9Km-2dA")]
    [Description(@"Indicates a Financial Institution Credit Transfer Payment.")]
    FinancialInstitutionCreditTransferPayment,
    
    /// <summary>
    /// Indicates a Financial Institution Credit Transfer Payment status update.
    /// Encoded/decoded by serializers as &quot;FTSU&quot;.
    /// </summary>
    [EnumMember(Value = "FTSU")]
    [IsoId("_ktWjMFnoEemOfpP9Km-2dA")]
    [Description(@"Indicates a Financial Institution Credit Transfer Payment status update.")]
    StatusUpdateFinancialInstitutionCreditTransferPayment,
    
}
