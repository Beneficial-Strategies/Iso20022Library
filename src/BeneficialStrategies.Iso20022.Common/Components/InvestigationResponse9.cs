// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Response9.
/// </summary>
[IsoId("_muTP8TrQEe-thIfLZ94a1w")]
[DisplayName("Investigation Response9")]
public record InvestigationResponse9
{
    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required Max35Text MessageIdentification { get; init; }

    /// <summary>
    /// Responder Investigation Identification.
    /// </summary>
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public Max35Text? ResponderInvestigationIdentification { get; init; }

    /// <summary>
    /// Investigation Status.
    /// </summary>
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public required InvestigationStatus2 InvestigationStatus { get; init; }

    /// <summary>
    /// Next Responder.
    /// </summary>
    [DisplayName("Next Responder")]
    [IsoXmlTag("NxtRspndr")]
    public Party40Choice_? NextResponder { get; init; }

    /// <summary>
    /// Investigation Data.
    /// </summary>
    [DisplayName("Investigation Data")]
    [IsoXmlTag("InvstgtnData")]
    public ValueList<InvestigationData6> InvestigationData { get; init; } = [];
}
