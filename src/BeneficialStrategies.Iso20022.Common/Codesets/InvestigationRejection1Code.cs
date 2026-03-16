// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for rejecting an investigation case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_abwLM9p-Ed-ak6NoX_4Aeg_-283942395")]
[Description(@"Specifies the reason for rejecting an investigation case.")]
[DerivedFrom(typeof(InvestigationRejectionCode))]
public enum InvestigationRejection1Code
{
    /// <summary>
    /// Underlying instruction can not be found.
    /// Encoded/decoded by serializers as &quot;NFND&quot;.
    /// </summary>
    [EnumMember(Value = "NFND")]
    [IsoId("_abwLNNp-Ed-ak6NoX_4Aeg_-283942364")]
    [Description(@"Underlying instruction can not be found.")]
    UnderlyingPaymentNotFound = InvestigationRejectionCode.UnderlyingPaymentNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case assignee is not allowed to investigate on this instruction or a party has been by-passed in the payment chain or no bilateral agreement has been established for this type of query.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_abwLNdp-Ed-ak6NoX_4Aeg_-283942363")]
    [Description(
        @"Case assignee is not allowed to investigate on this instruction or a party has been by-passed in the payment chain or no bilateral agreement has been established for this type of query."
    )]
    NotAuthorisedToInvestigate = InvestigationRejectionCode.NotAuthorisedToInvestigate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_abwLNtp-Ed-ak6NoX_4Aeg_-283942362")]
    [Description(@"Case has never been assigned before.")]
    UnknownCase = InvestigationRejectionCode.UnknownCase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when the payment instruction has previously been cancelled or rejected.
    /// Encoded/decoded by serializers as &quot;PCOR&quot;.
    /// </summary>
    [EnumMember(Value = "PCOR")]
    [IsoId("_abwLN9p-Ed-ak6NoX_4Aeg_-283942334")]
    [Description(@"Used when the payment instruction has previously been cancelled or rejected.")]
    PaymentPreviouslyCancelledOrRejected =
        InvestigationRejectionCode.PaymentPreviouslyCancelledOrRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wrong message has been used in the investigation workflow.
    /// Encoded/decoded by serializers as &quot;WMSG&quot;.
    /// </summary>
    [EnumMember(Value = "WMSG")]
    [IsoId("_abwLONp-Ed-ak6NoX_4Aeg_-174967773")]
    [Description(@"Wrong message has been used in the investigation workflow.")]
    WrongMessage = InvestigationRejectionCode.WrongMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used to reject a non-cash related query that is not covered in the workflow.
    /// Encoded/decoded by serializers as &quot;RNCR&quot;.
    /// </summary>
    [EnumMember(Value = "RNCR")]
    [IsoId("_ab58MNp-Ed-ak6NoX_4Aeg_1887051953")]
    [Description(@"Used to reject a non-cash related query that is not covered in the workflow.")]
    RejectNonCashRelated = InvestigationRejectionCode.RejectNonCashRelated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resolution of Investigation has not been received on reopened case.
    /// Encoded/decoded by serializers as &quot;MROI&quot;.
    /// </summary>
    [EnumMember(Value = "MROI")]
    [IsoId("_ab58Mdp-Ed-ak6NoX_4Aeg_-538416824")]
    [Description(@"Resolution of Investigation has not been received on reopened case.")]
    MissingResolutionOfInvestigation = InvestigationRejectionCode.MissingResolutionOfInvestigation, // same ordinal as derivation source for type conversions
}
