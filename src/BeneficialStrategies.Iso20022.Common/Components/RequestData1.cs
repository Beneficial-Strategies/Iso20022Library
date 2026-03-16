// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the meta data for a netting cut off update request: message identification, request servicer and a request type.
/// </summary>
[IsoId("_vL8UIJVFEeaYkf5FCqYMeA")]
[DisplayName("Request Data")]
public record RequestData1
{
    /// <summary>
    /// Unique identification of the message.
    /// </summary>
    [IsoId("_F1X_IJVGEeaYkf5FCqYMeA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Description of the type of request.
    /// </summary>
    [IsoId("_V4DYkJVGEeaYkf5FCqYMeA")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text RequestType { get; init; }

    /// <summary>
    /// Specifies the business date on which the new netting cut off(s) is (are) to be activated.
    /// </summary>
    [IsoId("_9-M4EZnmEeaKH-pm9fIa8w")]
    [DisplayName("Requested Activation Date")]
    [IsoXmlTag("ReqdActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedActivationDate { get; init; }

    /// <summary>
    /// Describes the central system servicing the request.
    /// </summary>
    [IsoId("_PFii8JVGEeaYkf5FCqYMeA")]
    [DisplayName("Request Servicer")]
    [IsoXmlTag("ReqSvcr")]
    public PartyIdentification73Choice_? RequestServicer { get; init; }

    /// <summary>
    /// Describes the participant issuing the request.
    /// </summary>
    [IsoId("_1xniEZnvEeahw7LV9elg3w")]
    [DisplayName("Net Service Participant Identification")]
    [IsoXmlTag("NetSvcPtcptId")]
    public required PartyIdentification73Choice_ NetServiceParticipantIdentification { get; init; }

    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_l9h34ZnnEeaKH-pm9fIa8w")]
    [DisplayName("Net Service Type")]
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NetServiceType { get; init; }
}
