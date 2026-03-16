// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraudulent Transaction Data3.
/// </summary>
[IsoId("_mmS6IZLBEe6TWIDarRgYow")]
[DisplayName("Fraudulent Transaction Data3")]
public record FraudulentTransactionData3
{
    /// <summary>
    /// Alternate Message Reason.
    /// </summary>
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public ValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Authorisation.
    /// </summary>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public IsoTrueFalseIndicator? Authorisation { get; init; }

    /// <summary>
    /// Authorisation Entity.
    /// </summary>
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public PartyType26Code? AuthorisationEntity { get; init; }

    /// <summary>
    /// Dispute Condition.
    /// </summary>
    [DisplayName("Dispute Condition")]
    [IsoXmlTag("DsptCond")]
    public IsoMax35Text? DisputeCondition { get; init; }

    /// <summary>
    /// Dispute Reference.
    /// </summary>
    [DisplayName("Dispute Reference")]
    [IsoXmlTag("DsptRef")]
    public ValueList<DisputeReference1> DisputeReference { get; init; } = [];

    /// <summary>
    /// Fraudulent Message.
    /// </summary>
    [DisplayName("Fraudulent Message")]
    [IsoXmlTag("FrdlntMsg")]
    public IsoMax100KBinary? FraudulentMessage { get; init; }

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Other Authorisation Entity.
    /// </summary>
    [DisplayName("Other Authorisation Entity")]
    [IsoXmlTag("OthrAuthstnNtty")]
    public IsoMax35Text? OtherAuthorisationEntity { get; init; }

    /// <summary>
    /// Presentment Cycle.
    /// </summary>
    [DisplayName("Presentment Cycle")]
    [IsoXmlTag("PresntmntCycl")]
    public IsoExact1NumericText? PresentmentCycle { get; init; }
}
