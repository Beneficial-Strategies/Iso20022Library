// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the confirmed fraudulent transaction.
/// </summary>
[IsoId("_-RODYcsGEeuNe7RtB4qFHw")]
[DisplayName("Fraudulent Transaction Data")]
public record FraudulentTransactionData2
{
    /// <summary>
    /// Status of authorisation of the fraudulent transaction.
    /// </summary>
    [IsoId("_-WlEgcsGEeuNe7RtB4qFHw")]
    [DisplayName("Authorisation Status")]
    [IsoXmlTag("AuthstnSts")]
    public AuthorisationStatus1? AuthorisationStatus { get; init; }

    /// <summary>
    /// Details of the dispute if and when relevant.
    /// </summary>
    [IsoId("_-WlrkcsGEeuNe7RtB4qFHw")]
    [DisplayName("Dispute Details")]
    [IsoXmlTag("DsptDtls")]
    public DisputeData2? DisputeDetails { get; init; }

    /// <summary>
    /// Reason for sending the message.
    /// The ISO 8583 maintenance agency (MA) manages this Message reason code list.
    /// </summary>
    [IsoId("_-Wlrk8sGEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ISO8583MessageReasonCode? MessageReason { get; init; }

    /// <summary>
    /// Supports message reason codes that are not defined  in external code list.
    /// </summary>
    [IsoId("_-WlrlcsGEeuNe7RtB4qFHw")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; }

    /// <summary>
    /// Complete or partial details of the original message identified as fraudulent.
    /// </summary>
    [IsoId("_-Wlrl8sGEeuNe7RtB4qFHw")]
    [DisplayName("Fraudulent Message")]
    [IsoXmlTag("FrdlntMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? FraudulentMessage { get; init; }
}
