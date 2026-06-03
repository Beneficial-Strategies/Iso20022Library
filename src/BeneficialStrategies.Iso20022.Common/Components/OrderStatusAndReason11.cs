// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order that was previously received.
/// </summary>
[IsoId("7bf19d06-83dc-4b83-b0c9-5e1b2fe5f345")]
[DisplayName("Order Status And Reason11")]
public record OrderStatusAndReason11
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("e5b401d7-d23a-48c9-a81d-0fab9550b322")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Status of a 'bulk' of orders. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
    /// </summary>
    [IsoId("d7834134-e7b8-4142-9225-616d1a15d35a")]
    [DisplayName("Order Status")]
    [IsoXmlTag("OrdrSts")]
    public required OrderStatus8Choice_ OrderStatus { get; init; }

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("df765273-aebb-42b0-8fa8-14776ee3e946")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }
}
