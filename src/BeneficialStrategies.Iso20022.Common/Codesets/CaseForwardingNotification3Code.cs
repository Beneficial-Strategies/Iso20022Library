// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action requested when forwarding a case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2bVAtp-Ed-ak6NoX_4Aeg_-1716921082")]
[Description(@"Specifies the action requested when forwarding a case.")]
[DerivedFrom(typeof(CaseForwardingNotificationCode))]
public enum CaseForwardingNotification3Code
{
    /// <summary>
    /// Case has been forwarded to the next party for further investigation.
    /// Encoded/decoded by serializers as &quot;FTHI&quot;.
    /// </summary>
    [EnumMember(Value = "FTHI")]
    [IsoId("_a2bVA9p-Ed-ak6NoX_4Aeg_-1716921080")]
    [Description(@"Case has been forwarded to the next party for further investigation.")]
    FurtherInvestigation = CaseForwardingNotificationCode.FurtherInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for cancellation.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_a2bVBNp-Ed-ak6NoX_4Aeg_-1716921060")]
    [Description(@"Case has been forwarded to the next party for cancellation.")]
    RequestToCancel = CaseForwardingNotificationCode.RequestToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for modification.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_a2bVBdp-Ed-ak6NoX_4Aeg_-1716921051")]
    [Description(@"Case has been forwarded to the next party for modification.")]
    RequestToModify = CaseForwardingNotificationCode.RequestToModify, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to obtain authorisation to debit.
    /// Encoded/decoded by serializers as &quot;DTAU&quot;.
    /// </summary>
    [EnumMember(Value = "DTAU")]
    [IsoId("_a2bVBtp-Ed-ak6NoX_4Aeg_-1716921029")]
    [Description(@"Case has been forwarded to obtain authorisation to debit.")]
    RequestDebitAuthorisation = CaseForwardingNotificationCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional information has been forwarded to the creditor.
    /// Encoded/decoded by serializers as &quot;SAIN&quot;.
    /// </summary>
    [EnumMember(Value = "SAIN")]
    [IsoId("_a2bVB9p-Ed-ak6NoX_4Aeg_-1716921020")]
    [Description(@"Additional information has been forwarded to the creditor.")]
    SentAdditionalInformation = CaseForwardingNotificationCode.SentAdditionalInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case is been handled by the assigned party.
    /// Encoded/decoded by serializers as &quot;MINE&quot;.
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_a2bVCNp-Ed-ak6NoX_4Aeg_-1716921019")]
    [Description(@"Case is been handled by the assigned party.")]
    MineInvestigationCase = CaseForwardingNotificationCode.MineInvestigationCase, // same ordinal as derivation source for type conversions
}
