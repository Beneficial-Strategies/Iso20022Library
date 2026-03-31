// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2SLFNp-Ed-ak6NoX_4Aeg_-638403866")]
[Description(
    @"Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners."
)]
[DerivedFrom(typeof(CaseForwardingNotificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CaseForwardingNotification2Code>))]
#endif
public enum CaseForwardingNotification2Code
{
    /// <summary>
    /// Case has been forwarded to the next party for further investigation.
    /// Encoded/decoded by serializers as &quot;FTHI&quot;.
    /// </summary>
    [EnumMember(Value = "FTHI")]
    [IsoId("_a2SLFdp-Ed-ak6NoX_4Aeg_-638403848")]
    [Description(@"Case has been forwarded to the next party for further investigation.")]
    FurtherInvestigation = CaseForwardingNotificationCode.FurtherInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for cancellation.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_a2SLFtp-Ed-ak6NoX_4Aeg_-638403614")]
    [Description(@"Case has been forwarded to the next party for cancellation.")]
    RequestToCancel = CaseForwardingNotificationCode.RequestToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for modification.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_a2SLF9p-Ed-ak6NoX_4Aeg_-638403589")]
    [Description(@"Case has been forwarded to the next party for modification.")]
    RequestToModify = CaseForwardingNotificationCode.RequestToModify, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to obtain authorisation to debit.
    /// Encoded/decoded by serializers as &quot;DTAU&quot;.
    /// </summary>
    [EnumMember(Value = "DTAU")]
    [IsoId("_a2SLGNp-Ed-ak6NoX_4Aeg_-638403537")]
    [Description(@"Case has been forwarded to obtain authorisation to debit.")]
    RequestDebitAuthorisation = CaseForwardingNotificationCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional information has been forwarded to the creditor.
    /// Encoded/decoded by serializers as &quot;SAIN&quot;.
    /// </summary>
    [EnumMember(Value = "SAIN")]
    [IsoId("_a2bVANp-Ed-ak6NoX_4Aeg_-638403494")]
    [Description(@"Additional information has been forwarded to the creditor.")]
    SentAdditionalInformation = CaseForwardingNotificationCode.SentAdditionalInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case is taken up by an assigned agent.
    /// Encoded/decoded by serializers as &quot;FIAG&quot;.
    /// </summary>
    [EnumMember(Value = "FIAG")]
    [IsoId("_a2bVAdp-Ed-ak6NoX_4Aeg_-638403493")]
    [Description(@"Case is taken up by an assigned agent.")]
    FoundInvestigatingAgent = CaseForwardingNotificationCode.FoundInvestigatingAgent, // same ordinal as derivation source for type conversions
}
