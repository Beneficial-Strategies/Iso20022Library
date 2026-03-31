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
[IsoId("_VnACxNp-Ed-ak6NoX_4Aeg_-877395584")]
[Description(
    @"Specifies the action requested when forwarding a case. Assignees taking the decision to cancel or modify to further case assignees must communicate this decision to their case assigners."
)]
[DerivedFrom(typeof(CaseForwardingNotificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CaseForwardingNotification1Code>))]
#endif
public enum CaseForwardingNotification1Code
{
    /// <summary>
    /// Case has been forwarded to the next party for further investigation.
    /// Encoded/decoded by serializers as &quot;FTHI&quot;.
    /// </summary>
    [EnumMember(Value = "FTHI")]
    [IsoId("_VnACxdp-Ed-ak6NoX_4Aeg_-523684722")]
    [Description(@"Case has been forwarded to the next party for further investigation.")]
    FurtherInvestigation = CaseForwardingNotificationCode.FurtherInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for cancellation.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_VnACxtp-Ed-ak6NoX_4Aeg_-494133924")]
    [Description(@"Case has been forwarded to the next party for cancellation.")]
    RequestToCancel = CaseForwardingNotificationCode.RequestToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to the next party for modification.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_VnACx9p-Ed-ak6NoX_4Aeg_-482125812")]
    [Description(@"Case has been forwarded to the next party for modification.")]
    RequestToModify = CaseForwardingNotificationCode.RequestToModify, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Case has been forwarded to obtain authorisation to debit.
    /// Encoded/decoded by serializers as &quot;DTAU&quot;.
    /// </summary>
    [EnumMember(Value = "DTAU")]
    [IsoId("_VnACyNp-Ed-ak6NoX_4Aeg_1373273539")]
    [Description(@"Case has been forwarded to obtain authorisation to debit.")]
    RequestDebitAuthorisation = CaseForwardingNotificationCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional information has been forwarded to the creditor.
    /// Encoded/decoded by serializers as &quot;SAIN&quot;.
    /// </summary>
    [EnumMember(Value = "SAIN")]
    [IsoId("_VnJzwNp-Ed-ak6NoX_4Aeg_1094083878")]
    [Description(@"Additional information has been forwarded to the creditor.")]
    SentAdditionalInformation = CaseForwardingNotificationCode.SentAdditionalInformation, // same ordinal as derivation source for type conversions
}
