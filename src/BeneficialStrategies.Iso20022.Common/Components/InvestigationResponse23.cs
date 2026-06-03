// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the investigation response.
/// </summary>
[IsoId("9513563d-a3a4-4a7a-b2f5-d441d1d76af8")]
[DisplayName("Investigation Response23")]
public record InvestigationResponse23
{
    /// <summary>
    /// Point to point reference, as assigned by the responder, and sent to the requestor to unambiguously identify the message.
    /// </summary>
    [IsoId("a8be19d8-ddfd-43f6-b3f8-75e3711eadb7")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the responder, to unambiguously identify the responder reference for the investigation.
    /// </summary>
    [IsoId("90e06376-b619-4654-af50-826857c84c47")]
    [DisplayName("Responder Investigation Identification")]
    [IsoXmlTag("RspndrInvstgtnId")]
    public IsoMax35Text? ResponderInvestigationIdentification { get; init; }

    /// <summary>
    /// Status of the investigation request.
    /// </summary>
    [IsoId("28b406cd-d3e5-49fa-aa33-6f9c2b4b01f2")]
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public required InvestigationStatus2 InvestigationStatus { get; init; }

    /// <summary>
    /// Identification of the party or agent the responder is awaiting a response from.
    /// </summary>
    [IsoId("ecfb3f49-6c88-4363-8775-5ae7344e83c8")]
    [DisplayName("Next Responder")]
    [IsoXmlTag("NxtRspndr")]
    public Party40Choice? NextResponder { get; init; }

    /// <summary>
    /// Provides the response to the request.
    /// </summary>
    [IsoId("39d67578-0805-482a-972f-fc54f6566d4f")]
    [DisplayName("Investigation Data")]
    [IsoXmlTag("InvstgtnData")]
    public ValueList<InvestigationData18> InvestigationData { get; init; } = [];
}
