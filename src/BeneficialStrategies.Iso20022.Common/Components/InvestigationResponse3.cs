// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Response3.
/// </summary>
[IsoId("_vCrfMWNvEe6n_IAhQTgk8Q")]
[DisplayName("Investigation Response3")]
public partial record InvestigationResponse3
{
    #nullable enable

    /// <summary>
    /// Investigation Data.
    /// </summary>
    [DisplayName("Investigation Data")]
    [IsoXmlTag("InvstgtnData")]
    public ValueList<InvestigationData2> InvestigationData { get; init; } = [];

    /// <summary>
    /// Investigation Status.
    /// </summary>
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public required InvestigationStatus2 InvestigationStatus { get; init; } 

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; } 

    /// <summary>
    /// Next Responder.
    /// </summary>
    [DisplayName("Next Responder")]
    [IsoXmlTag("NxtRspndr")]
    public Party40Choice_? NextResponder { get; init; } 

    /// <summary>
    /// Responder Investigation Identification.
    /// </summary>
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; } 

    
    #nullable disable
    
}
