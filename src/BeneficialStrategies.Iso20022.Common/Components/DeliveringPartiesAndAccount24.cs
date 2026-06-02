// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("14a3b54d-45b4-4a35-a568-d44c3cdd0a53")]
[DisplayName("Delivering Parties And Account24")]
public record DeliveringPartiesAndAccount24
{
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("3b10f161-19d5-44c7-92ed-5a3ba4011649")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount235? DeliverersCustodianDetails { get; init; }

    /// <summary>
    /// Party that the deliverer's custodian uses to effect the delivery of a security, when the deliverer's custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("419587f7-37a5-4ab8-a8c2-ce6ec789aba1")]
    [DisplayName("Deliverers Intermediary1 Details")]
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount235? DeliverersIntermediary1Details { get; init; }

    /// <summary>
    /// Party that interacts with the deliverer's intermediary 1.
    /// </summary>
    [IsoId("f8427d5e-d47e-4aed-b654-fd657e01f288")]
    [DisplayName("Deliverers Intermediary2 Details")]
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount235? DeliverersIntermediary2Details { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("9cdcb279-f9dd-4abe-8c0c-5cdc13350152")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount235 DeliveringAgentDetails { get; init; }
}
