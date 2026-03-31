// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2bVCdp-Ed-ak6NoX_4Aeg_-1197135711")]
[Description(
    @"Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners."
)]
[Derivations(
    typeof(CaseForwardingNotification1Code),
    typeof(CaseForwardingNotification2Code),
    typeof(CaseForwardingNotification3Code)
)]
public enum CaseForwardingNotificationCode
{
    /// <summary>
    /// Case has been forwarded to the next party for further investigation.
    /// Encoded/decoded by serializers as &quot;FTHI&quot;.
    /// </summary>
    [EnumMember(Value = "FTHI")]
    [IsoId("_a2lGANp-Ed-ak6NoX_4Aeg_1336952025")]
    [Description(@"Case has been forwarded to the next party for further investigation.")]
    FurtherInvestigation,

    /// <summary>
    /// Case has been forwarded to the next party for cancellation.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_a2lGAdp-Ed-ak6NoX_4Aeg_1345261208")]
    [Description(@"Case has been forwarded to the next party for cancellation.")]
    RequestToCancel,

    /// <summary>
    /// Case has been forwarded to the next party for modification.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_a2lGAtp-Ed-ak6NoX_4Aeg_1345261251")]
    [Description(@"Case has been forwarded to the next party for modification.")]
    RequestToModify,

    /// <summary>
    /// Case has been forwarded to obtain authorisation to debit.
    /// Encoded/decoded by serializers as &quot;DTAU&quot;.
    /// </summary>
    [EnumMember(Value = "DTAU")]
    [IsoId("_a2lGA9p-Ed-ak6NoX_4Aeg_1345261268")]
    [Description(@"Case has been forwarded to obtain authorisation to debit.")]
    RequestDebitAuthorisation,

    /// <summary>
    /// Additional information has been forwarded to the creditor.
    /// Encoded/decoded by serializers as &quot;SAIN&quot;.
    /// </summary>
    [EnumMember(Value = "SAIN")]
    [IsoId("_a2lGBNp-Ed-ak6NoX_4Aeg_1345261311")]
    [Description(@"Additional information has been forwarded to the creditor.")]
    SentAdditionalInformation,

    /// <summary>
    /// Case is taken up by an assigned agent.
    /// Encoded/decoded by serializers as &quot;FIAG&quot;.
    /// </summary>
    [EnumMember(Value = "FIAG")]
    [IsoId("_a2lGBdp-Ed-ak6NoX_4Aeg_-1167583028")]
    [Description(@"Case is taken up by an assigned agent.")]
    FoundInvestigatingAgent,

    /// <summary>
    /// Case is been handled by the assigned party.
    /// Encoded/decoded by serializers as &quot;MINE&quot;.
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_a2lGBtp-Ed-ak6NoX_4Aeg_893067344")]
    [Description(@"Case is been handled by the assigned party.")]
    MineInvestigationCase,
}
