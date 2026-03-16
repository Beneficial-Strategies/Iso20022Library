// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Request2.
/// </summary>
[IsoId("_pBE7YWNqEe6rDI7BtgptxA")]
[DisplayName("Investigation Request2")]
public partial record InvestigationRequest2
{
    #nullable enable

    /// <summary>
    /// EIR.
    /// </summary>
    [DisplayName("EIR")]
    [IsoXmlTag("EIR")]
    public IsoUUIDv4Identifier? EIR { get; init; } 

    /// <summary>
    /// Expected Responder.
    /// </summary>
    [DisplayName("Expected Responder")]
    [IsoXmlTag("XpctdRspndr")]
    public Party40Choice_? ExpectedResponder { get; init; } 

    /// <summary>
    /// Investigation Sub Type.
    /// </summary>
    [DisplayName("Investigation Sub Type")]
    [IsoXmlTag("InvstgtnSubTp")]
    public InvestigationSubType1Choice_? InvestigationSubType { get; init; } 

    /// <summary>
    /// Investigation Type.
    /// </summary>
    [DisplayName("Investigation Type")]
    [IsoXmlTag("InvstgtnTp")]
    public required InvestigationType1Choice_ InvestigationType { get; init; } 

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; } 

    /// <summary>
    /// Request Action.
    /// </summary>
    [DisplayName("Request Action")]
    [IsoXmlTag("ReqActn")]
    public InvestigationRequestAction1? RequestAction { get; init; } 

    /// <summary>
    /// Requestor.
    /// </summary>
    [DisplayName("Requestor")]
    [IsoXmlTag("Rqstr")]
    public required Party40Choice_ Requestor { get; init; } 

    /// <summary>
    /// Request Originator.
    /// </summary>
    [DisplayName("Request Originator")]
    [IsoXmlTag("ReqOrgtr")]
    public Party40Choice_? RequestOriginator { get; init; } 

    /// <summary>
    /// Requestor Investigation Identification.
    /// </summary>
    [DisplayName("Requestor Investigation Identification")]
    [IsoXmlTag("RqstrInvstgtnId")]
    public IsoMax35Text? RequestorInvestigationIdentification { get; init; } 

    /// <summary>
    /// Responder.
    /// </summary>
    [DisplayName("Responder")]
    [IsoXmlTag("Rspndr")]
    public required Party40Choice_ Responder { get; init; } 

    /// <summary>
    /// Responder Investigation Identification.
    /// </summary>
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; } 

    /// <summary>
    /// Service Level.
    /// </summary>
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<InvestigationServiceLevel1Choice_> ServiceLevel { get; init; } = [];

    /// <summary>
    /// Underlying.
    /// </summary>
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingData2Choice_ Underlying { get; init; } 

    /// <summary>
    /// Underlying Instrument.
    /// </summary>
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public UnderlyingInvestigationInstrument1Choice_? UnderlyingInstrument { get; init; } 

    
    #nullable disable
    
}
