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
[IsoId("_VVF_YXR3EfC68Y4jZPNEug")]
[DisplayName("Fraudulent Transaction Data4")]
public record FraudulentTransactionData4
{
    /// <summary>
    /// Indicates whether the transaction was authorised or not.
    /// </summary>
    [IsoId("_VXnH4XR3EfC68Y4jZPNEug")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public IsoTrueFalseIndicator? Authorisation { get; init; }

    /// <summary>
    /// Indicates the entity which authorised the transaction (if relevant).
    /// </summary>
    [IsoId("_VXnH43R3EfC68Y4jZPNEug")]
    [DisplayName("Authorisation Entity")]
    [IsoXmlTag("AuthstnNtty")]
    public ATICAPartyType1Code? AuthorisationEntity { get; init; }

    /// <summary>
    /// Reason for sending the message.
    /// </summary>
    [IsoId("_VXnH7XR3EfC68Y4jZPNEug")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_VXnH-3R3EfC68Y4jZPNEug")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Indicates the cycle of presentment or of the chargeback.
    /// </summary>
    [IsoId("_VXnH53R3EfC68Y4jZPNEug")]
    [DisplayName("Presentment Cycle")]
    [IsoXmlTag("PresntmntCycl")]
    public IsoExact1NumericText? PresentmentCycle { get; init; }

    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_VXnH6XR3EfC68Y4jZPNEug")]
    [DisplayName("Dispute Condition")]
    [IsoXmlTag("DsptCond")]
    public IsoMax35Text? DisputeCondition { get; init; }

    /// <summary>
    /// Bundle dispute case reference assigned by agent.
    /// </summary>
    [IsoId("_Dm_JdHR4EfC68Y4jZPNEug")]
    [DisplayName("Agent Dispute Bundle Case Reference")]
    [IsoXmlTag("AgtDsptBndlCaseRef")]
    public IsoMax20Text? AgentDisputeBundleCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by agent.
    /// </summary>
    [IsoId("_Dm_JdXR4EfC68Y4jZPNEug")]
    [DisplayName("Agent Dispute Case Reference")]
    [IsoXmlTag("AgtDsptCaseRef")]
    public IsoMax20Text? AgentDisputeCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by acquirer.
    /// </summary>
    [IsoId("_Dm_JdnR4EfC68Y4jZPNEug")]
    [DisplayName("Acquirer Dispute Case Reference")]
    [IsoXmlTag("AcqrrDsptCaseRef")]
    public IsoMax20Text? AcquirerDisputeCaseReference { get; init; }

    /// <summary>
    /// Dispute case reference assigned by issuer.
    /// </summary>
    [IsoId("_Dm_Jd3R4EfC68Y4jZPNEug")]
    [DisplayName("Issuer Dispute Case Reference")]
    [IsoXmlTag("IssrDsptCaseRef")]
    public IsoMax20Text? IssuerDisputeCaseReference { get; init; }

    /// <summary>
    /// Complete or partial details of the original message identified as fraudulent.
    /// </summary>
    [IsoId("_VXnH_XR3EfC68Y4jZPNEug")]
    [DisplayName("Fraudulent Message")]
    [IsoXmlTag("FrdlntMsg")]
    public IsoMax100KBinary? FraudulentMessage { get; init; }
}
