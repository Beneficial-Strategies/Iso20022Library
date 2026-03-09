// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of cancellation requests.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auruQ9p-Ed-ak6NoX_4Aeg_-1224774658")]
[Description(@"Specifies the status of a group of cancellation requests.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum GroupCancellationStatus1Code
{
    /// <summary>
    /// Cancellation is partially accepted.
    /// Encoded/decoded by serializers as &quot;PACR&quot;.
    /// </summary>
    [EnumMember(Value = "PACR")]
    [IsoId("_auruRNp-Ed-ak6NoX_4Aeg_-305868783")]
    [Description(@"Cancellation is partially accepted.")]
    PartiallyAcceptedCancellationRequest = PaymentStatusCode.PartiallyAcceptedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_auruRdp-Ed-ak6NoX_4Aeg_-305868753")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest = PaymentStatusCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_auruRtp-Ed-ak6NoX_4Aeg_-305868752")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest = PaymentStatusCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_auruR9p-Ed-ak6NoX_4Aeg_-91612397")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest = PaymentStatusCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
}
