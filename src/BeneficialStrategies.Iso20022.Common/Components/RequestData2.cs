// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the meta data for netting cut off update request: message identification, request servicer and a request type.
/// </summary>
[IsoId("_CnJABQN1Ee2-vqzwMUAewg")]
[DisplayName("Request Data")]
public record RequestData2
{
    /// <summary>
    /// Unique identification of the message.
    /// </summary>
    [IsoId("_CswfwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Description of the type of request.
    /// </summary>
    [IsoId("_CswfwwN1Ee2-vqzwMUAewg")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text RequestType { get; init; }

    /// <summary>
    /// Specifies the business date on which the new netting cut off(s) is (are) to be activated.
    /// </summary>
    [IsoId("_CswfxQN1Ee2-vqzwMUAewg")]
    [DisplayName("Requested Activation Date")]
    [IsoXmlTag("ReqdActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedActivationDate { get; init; }

    /// <summary>
    /// Describes the central system servicing the request.
    /// </summary>
    [IsoId("_CswfxwN1Ee2-vqzwMUAewg")]
    [DisplayName("Request Servicer")]
    [IsoXmlTag("ReqSvcr")]
    public PartyIdentification242Choice_? RequestServicer { get; init; }

    /// <summary>
    /// Describes the participant issuing the request.
    /// </summary>
    [IsoId("_CswfyQN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Participant Identification")]
    [IsoXmlTag("NetSvcPtcptId")]
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; }

    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_CswfywN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Type")]
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NetServiceType { get; init; }
}
