// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2IaEdp-Ed-ak6NoX_4Aeg_-2044863229")]
[Description(@"Specifies the reason for not accepting a Case.")]
[DerivedFrom(typeof(CaseAssignmentRejectionCode))]
public enum CaseAssignmentRejection2Code
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as &quot;NFND&quot;.
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_a2IaEtp-Ed-ak6NoX_4Aeg_-2044862916")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound = CaseAssignmentRejectionCode.UnderlyingPaymentNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_a2IaE9p-Ed-ak6NoX_4Aeg_-2044862899")]
    [Description(@"Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).")]
    NotAuthorisedToInvestigate = CaseAssignmentRejectionCode.NotAuthorisedToInvestigate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2IaFNp-Ed-ak6NoX_4Aeg_-2044862857")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase = CaseAssignmentRejectionCode.UnknownCase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the payment instruction has previously been cancelled or rejected.
    /// Encoded/decoded by serializers as &quot;PCOR&quot;.
    /// </summary>
    [EnumMember(Value = "PCOR")]
    [IsoId("_a2IaFdp-Ed-ak6NoX_4Aeg_-2044862530")]
    [Description(@"Used when the payment instruction has previously been cancelled or rejected.")]
    PaymentPreviouslyCancelledOrRejected = CaseAssignmentRejectionCode.PaymentPreviouslyCancelledOrRejected, // same ordinal as derivation source for type conversions
    
}
