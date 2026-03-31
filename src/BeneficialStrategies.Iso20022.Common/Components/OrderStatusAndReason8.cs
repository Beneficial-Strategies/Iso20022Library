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
[IsoId("_RL4iV9p-Ed-ak6NoX_4Aeg_-1721469450")]
[DisplayName("Order Status And Reason")]
public record OrderStatusAndReason8
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RL4iWNp-Ed-ak6NoX_4Aeg_441489185")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Cancellation status of the order.
    /// </summary>
    [IsoId("_RL4iWdp-Ed-ak6NoX_4Aeg_-1721469373")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderCancellationStatus1Code Status { get; init; }

    /// <summary>
    /// Status of the order cancellation request is rejected.
    /// </summary>
    [IsoId("_RL4iWtp-Ed-ak6NoX_4Aeg_1437989574")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus7 Rejected { get; init; }

    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("_RMBsQNp-Ed-ak6NoX_4Aeg_124535247")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }
}
