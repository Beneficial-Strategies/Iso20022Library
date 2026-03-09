// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for not accepting a Case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vm241tp-Ed-ak6NoX_4Aeg_-475726160")]
[Description(@"Specifies the reason for not accepting a Case.")]
[DerivedFrom(typeof(CaseAssignmentRejectionCode))]
public enum CaseAssignmentRejection1Code
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as &quot;NFND&quot;.
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_Vm2419p-Ed-ak6NoX_4Aeg_-407386472")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound = CaseAssignmentRejectionCode.UnderlyingPaymentNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_VnACwNp-Ed-ak6NoX_4Aeg_-48136805")]
    [Description(@"Case Assignee is not allowed to investigate on this instruction (eg. Case Assignee is not the next party in the payment chain).")]
    NotAuthorisedToInvestigate = CaseAssignmentRejectionCode.NotAuthorisedToInvestigate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_VnACwdp-Ed-ak6NoX_4Aeg_-1993051148")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase = CaseAssignmentRejectionCode.UnknownCase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the payment instruction has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_VnACwtp-Ed-ak6NoX_4Aeg_-1951794735")]
    [Description(@"Used when the payment instruction has been rejected.")]
    PaymentRejected = CaseAssignmentRejectionCode.PaymentRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the payment instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_VnACw9p-Ed-ak6NoX_4Aeg_-1881606195")]
    [Description(@"Used when the payment instruction has been cancelled.")]
    PaymentCancelled = CaseAssignmentRejectionCode.PaymentCancelled, // same ordinal as derivation source for type conversions
    
}
