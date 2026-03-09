// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2IaFtp-Ed-ak6NoX_4Aeg_-898092331")]
[Description(@"Specifies the reason for not accepting a Case.")]
[Derivations(typeof(CaseAssignmentRejection1Code),typeof(CaseAssignmentRejection2Code))]
public enum CaseAssignmentRejectionCode
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as &quot;NFND&quot;.
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_a2IaF9p-Ed-ak6NoX_4Aeg_-141872446")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound,
    
    /// <summary>
    /// Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_a2IaGNp-Ed-ak6NoX_4Aeg_-141872403")]
    [Description(@"Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).")]
    NotAuthorisedToInvestigate,
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2SLENp-Ed-ak6NoX_4Aeg_-141872368")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase,
    
    /// <summary>
    /// Used when the payment instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_a2SLEdp-Ed-ak6NoX_4Aeg_-141872333")]
    [Description(@"Used when the payment instruction has been rejected.")]
    PaymentRejected,
    
    /// <summary>
    /// Used when the payment instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a2SLEtp-Ed-ak6NoX_4Aeg_-141872308")]
    [Description(@"Used when the payment instruction has been cancelled.")]
    PaymentCancelled,
    
    /// <summary>
    /// Used when the payment instruction has previously been cancelled or rejected.
    /// Encoded/decoded by serializers as &quot;PCOR&quot;.
    /// </summary>
    [EnumMember(Value = "PCOR")]
    [IsoId("_a2SLE9p-Ed-ak6NoX_4Aeg_-795580088")]
    [Description(@"Used when the payment instruction has previously been cancelled or rejected.")]
    PaymentPreviouslyCancelledOrRejected,
    
}
