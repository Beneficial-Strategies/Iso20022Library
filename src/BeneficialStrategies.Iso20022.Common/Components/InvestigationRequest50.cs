// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of an investigation request, including identification and type.
/// </summary>
[IsoId("e41a7974-7534-48ea-b782-e1a47f9c6fea")]
[DisplayName("Investigation Request50")]
public record InvestigationRequest50
{
    /// <summary>
    /// Point to point reference, as assigned by the requestor, and sent to the responder to unambiguously identify the message.
    /// </summary>
    [IsoId("8c1eae58-e02c-417a-a68b-0a13b0f70445")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the requestor, to unambiguously identify the investigation for the requestor.
    /// </summary>
    [IsoId("86168a33-e1f7-48f9-b48b-f40870076e7b")]
    [DisplayName("Requestor Investigation Identification")]
    [IsoXmlTag("RqstrInvstgtnId")]
    public IsoMax35Text? RequestorInvestigationIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the responder, to unambiguously identify the investigation for the responder.
    /// </summary>
    [IsoId("b007bd45-f65c-4c6c-be8e-e3996b7348e3")]
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; }

    /// <summary>
    /// Unique identifier to provide the end-to-end reference of an investigation.
    /// </summary>
    [IsoId("cd68ffa0-7df0-4e0f-9604-55a237572f57")]
    [DisplayName("EIR")]
    [IsoXmlTag("EIR")]
    public IsoUUIDv4Identifier? EIR { get; init; }

    /// <summary>
    /// Specifies an action the responder should now take in regard to the investigation and the reason for the action.
    /// </summary>
    [IsoId("a7fb4727-2434-4865-989f-66b78ee1c8dd")]
    [DisplayName("Request Action")]
    [IsoXmlTag("ReqActn")]
    public InvestigationRequestAction1? RequestAction { get; init; }

    /// <summary>
    /// Type of investigation.
    /// </summary>
    [IsoId("a32ce0e0-6047-4dd2-8035-1e44b92d58de")]
    [DisplayName("Investigation Type")]
    [IsoXmlTag("InvstgtnTp")]
    public required InvestigationType1Choice_ InvestigationType { get; init; }

    /// <summary>
    /// Sub type of an investigation.
    /// </summary>
    [IsoId("293d2ff4-d3c6-4ec3-a362-08d008ab6ce6")]
    [DisplayName("Investigation Sub Type")]
    [IsoXmlTag("InvstgtnSubTp")]
    public InvestigationSubType1Choice_? InvestigationSubType { get; init; }

    /// <summary>
    /// Specifies the instrument or product to which the investigation refers.
    /// </summary>
    [IsoId("80930f31-42dd-4e52-ac6c-8c95f6dfd41b")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public UnderlyingInvestigationInstrument1Choice_? UnderlyingInstrument { get; init; }

    /// <summary>
    /// Provides details on the subject to which the investigation refers, for example a payment or statement entry.
    /// </summary>
    [IsoId("31e8dec9-3655-4869-a47d-58722f1fc00a")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public UnderlyingData13Choice_? Underlying { get; init; }

    /// <summary>
    /// Identification of the agent or party requesting a new investigation is opened or status update for an existing investigation.
    /// </summary>
    [IsoId("dfa41900-70c7-42af-acd4-43a6b8322f31")]
    [DisplayName("Requestor")]
    [IsoXmlTag("Rqstr")]
    public required Party40Choice_ Requestor { get; init; }

    /// <summary>
    /// Identification of the agent or party expected to open a new investigation or provide a status update for an existing investigation.
    /// </summary>
    [IsoId("9185cdfd-f816-4fc6-8edc-36e43f144072")]
    [DisplayName("Responder")]
    [IsoXmlTag("Rspndr")]
    public required Party40Choice_ Responder { get; init; }

    /// <summary>
    /// Identification of the agent or party who has originated the request.
    /// </summary>
    [IsoId("14772b7c-0c5c-47a5-82c1-a35783d0f431")]
    [DisplayName("Request Originator")]
    [IsoXmlTag("ReqOrgtr")]
    public Party40Choice_? RequestOriginator { get; init; }

    /// <summary>
    /// Identification of the agent or party who the requestor of the investigation expects the responder to contact in relation to the investigation request.
    /// </summary>
    [IsoId("be09f0b2-bce8-43fb-af1d-f825e1e88ef6")]
    [DisplayName("Expected Responder")]
    [IsoXmlTag("XpctdRspndr")]
    public Party40Choice_? ExpectedResponder { get; init; }

    /// <summary>
    /// Specifies a pre-agreed service or level of service between the requestor and responder.
    /// </summary>
    [IsoId("a3bb4cf5-4a5c-4f12-9410-f71ff554045a")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<InvestigationServiceLevel1Choice_> ServiceLevel { get; init; } = [];
}
