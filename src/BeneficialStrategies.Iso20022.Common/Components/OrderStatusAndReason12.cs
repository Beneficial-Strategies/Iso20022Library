// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("2bcad499-23bd-461b-8d53-b9a41a63bfbc")]
[DisplayName("Order Status And Reason12")]
public record OrderStatusAndReason12
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("2eb84416-f7ba-48c9-9894-4a0d3ef3c15d")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    [IsoId("f9caa157-3e02-49b3-95a7-d161d2f4f6b6")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public required CancellationStatus33Choice_ CancellationStatus { get; init; }

    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("13ac363a-2744-4878-9ffc-a858e20bd563")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }
}
