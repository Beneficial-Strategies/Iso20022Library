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
[IsoId("97cd2d16-d844-46d8-8996-23ce5c14b883")]
[DisplayName("Investigation Request51")]
public record InvestigationRequest51
{
    /// <summary>
    /// Point to point reference, as assigned by the requestor, and sent to the responder to unambiguously identify the message.
    /// </summary>
    [IsoId("89127cd5-eea9-4dec-8e5e-3887898fdc9c")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the requestor, to unambiguously identify the investigation for the requestor.
    /// </summary>
    [IsoId("80a9b986-2ae9-4bbc-9f3d-df786d16cb08")]
    [DisplayName("Requestor Investigation Identification")]
    [IsoXmlTag("RqstrInvstgtnId")]
    public IsoMax35Text? RequestorInvestigationIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the responder, to unambiguously identify the investigation for the responder.
    /// </summary>
    [IsoId("e0059d6f-4146-4e56-9c5b-260218a0a55b")]
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; }

    /// <summary>
    /// Unique identifier to provide the end-to-end reference of an investigation.
    /// </summary>
    [IsoId("57b1ed3a-8754-40fe-8ac6-2ad440383f2d")]
    [DisplayName("EIR")]
    [IsoXmlTag("EIR")]
    public IsoUUIDv4Identifier? EIR { get; init; }

    /// <summary>
    /// Specifies an action the responder should now take in regard to the investigation and the reason for the action.
    /// </summary>
    [IsoId("5eb9ed3b-6446-4d2e-ba4d-8811950f1106")]
    [DisplayName("Request Action")]
    [IsoXmlTag("ReqActn")]
    public InvestigationRequestAction1? RequestAction { get; init; }

    /// <summary>
    /// Type of investigation.
    /// </summary>
    [IsoId("7a573e25-1cc9-41af-80b9-5d285c6bf79c")]
    [DisplayName("Investigation Type")]
    [IsoXmlTag("InvstgtnTp")]
    public required InvestigationType1Choice InvestigationType { get; init; }

    /// <summary>
    /// Sub type of an investigation.
    /// </summary>
    [IsoId("bfd97282-9f6c-4900-aed8-38056aa52b86")]
    [DisplayName("Investigation Sub Type")]
    [IsoXmlTag("InvstgtnSubTp")]
    public InvestigationSubType1Choice? InvestigationSubType { get; init; }

    /// <summary>
    /// Specifies the instrument or product to which the investigation refers.
    /// </summary>
    [IsoId("86a1e805-9ad7-4cd6-a4a1-cecd0360e612")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public UnderlyingInvestigationInstrument1Choice? UnderlyingInstrument { get; init; }

    /// <summary>
    /// Provides details on the subject to which the investigation refers, for example a payment or statement entry.
    /// </summary>
    [IsoId("56354076-e327-4099-b068-0d665b1ed1ba")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingData13Choice Underlying { get; init; }

    /// <summary>
    /// Identification of the agent or party requesting a new investigation is opened or status update for an existing investigation.
    /// </summary>
    [IsoId("f068c2cb-d27e-48da-af3a-b4b47b89a56e")]
    [DisplayName("Requestor")]
    [IsoXmlTag("Rqstr")]
    public required Party40Choice Requestor { get; init; }

    /// <summary>
    /// Identification of the agent or party expected to open a new investigation or provide a status update for an existing investigation.
    /// </summary>
    [IsoId("026bca02-5a75-48ce-8de2-70a33ec20be3")]
    [DisplayName("Responder")]
    [IsoXmlTag("Rspndr")]
    public required Party40Choice Responder { get; init; }

    /// <summary>
    /// Identification of the agent or party who has originated the request.
    /// </summary>
    [IsoId("59d0e436-f102-4425-9a72-1d863f951c56")]
    [DisplayName("Request Originator")]
    [IsoXmlTag("ReqOrgtr")]
    public Party40Choice? RequestOriginator { get; init; }

    /// <summary>
    /// Identification of the agent or party who the requestor of the investigation expects the responder to contact in relation to the investigation request.
    /// </summary>
    [IsoId("6c3bae85-eab2-4ba0-b9b2-3b243ea60f80")]
    [DisplayName("Expected Responder")]
    [IsoXmlTag("XpctdRspndr")]
    public Party40Choice? ExpectedResponder { get; init; }

    /// <summary>
    /// Specifies a pre-agreed service or level of service between the requestor and responder.
    /// </summary>
    [IsoId("6c864e83-495c-4490-abca-3d3e0f29d0dd")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<InvestigationServiceLevel1Choice> ServiceLevel { get; init; } = [];
}
