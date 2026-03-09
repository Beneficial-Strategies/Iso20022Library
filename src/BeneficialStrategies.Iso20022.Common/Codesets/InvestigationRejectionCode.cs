// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for rejecting an investigation case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ab58Mtp-Ed-ak6NoX_4Aeg_-1473436095")]
[Description(@"Specifies the reason for rejecting an investigation case.")]
[Derivations(typeof(InvestigationRejection1Code))]
public enum InvestigationRejectionCode
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as &quot;NFND&quot;.
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_ab58M9p-Ed-ak6NoX_4Aeg_-1172368219")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound,
    
    /// <summary>
    /// Case assignee is not allowed to investigate on this instruction or a party has been by-passed in the payment chain or no bilateral agreement has been established for this type of query.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_ab58NNp-Ed-ak6NoX_4Aeg_-1172368188")]
    [Description(@"Case assignee is not allowed to investigate on this instruction or a party has been by-passed in the payment chain or no bilateral agreement has been established for this type of query.")]
    NotAuthorisedToInvestigate,
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_ab58Ndp-Ed-ak6NoX_4Aeg_-1172368187")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase,
    
    /// <summary>
    /// Used when the payment instruction has previously been cancelled or rejected.
    /// Encoded/decoded by serializers as &quot;PCOR&quot;.
    /// </summary>
    [EnumMember(Value = "PCOR")]
    [IsoId("_ab58Ntp-Ed-ak6NoX_4Aeg_-1172368147")]
    [Description(@"Used when the payment instruction has previously been cancelled or rejected.")]
    PaymentPreviouslyCancelledOrRejected,
    
    /// <summary>
    /// Wrong message has been used in the investigation workflow.
    /// Encoded/decoded by serializers as &quot;WMSG&quot;.
    /// </summary>
    [EnumMember(Value = "WMSG")]
    [IsoId("_ab58N9p-Ed-ak6NoX_4Aeg_-802961744")]
    [Description(@"Wrong message has been used in the investigation workflow.")]
    WrongMessage,
    
    /// <summary>
    /// Used to reject a non-cash related query that is not covered in the workflow.
    /// Encoded/decoded by serializers as &quot;RNCR&quot;.
    /// </summary>
    [EnumMember(Value = "RNCR")]
    [IsoId("_ab58ONp-Ed-ak6NoX_4Aeg_1741135512")]
    [Description(@"Used to reject a non-cash related query that is not covered in the workflow.")]
    RejectNonCashRelated,
    
    /// <summary>
    /// Resolution of Investigation has not been received on reopened case.
    /// Encoded/decoded by serializers as &quot;MROI&quot;.
    /// </summary>
    [EnumMember(Value = "MROI")]
    [IsoId("_ab58Odp-Ed-ak6NoX_4Aeg_-565196606")]
    [Description(@"Resolution of Investigation has not been received on reopened case.")]
    MissingResolutionOfInvestigation,
    
}
