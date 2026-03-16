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
[IsoId("_Uvkrg9p-Ed-ak6NoX_4Aeg_-1625631905")]
[DisplayName("Order Status And Reason")]
public record OrderStatusAndReason3
{
    /// <summary>
    /// Status of the order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_UvkrhNp-Ed-ak6NoX_4Aeg_-1625631879")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus2Code Status { get; init; }

    /// <summary>
    /// Status of the order details is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_Uvkrhdp-Ed-ak6NoX_4Aeg_-1625631489")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus1 Cancelled { get; init; }

    /// <summary>
    /// Status of the order details is conditionally accepted.
    /// </summary>
    [IsoId("_Uvkrhtp-Ed-ak6NoX_4Aeg_-1625631429")]
    [DisplayName("Conditionally Accepted")]
    [IsoXmlTag("CondlyAccptd")]
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; }

    /// <summary>
    /// Status of the order details is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_Uvkrh9p-Ed-ak6NoX_4Aeg_-1626490033")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus3 Rejected { get; init; }

    /// <summary>
    /// Status of the order details is suspended.
    /// </summary>
    [IsoId("_UvkriNp-Ed-ak6NoX_4Aeg_-1564859742")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    public required SuspendedStatus1 Suspended { get; init; }

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uvkridp-Ed-ak6NoX_4Aeg_-899308644")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }

    /// <summary>
    /// Unique and unambiguous technical identification of an instance of a leg within a switch.
    /// </summary>
    [IsoId("_Uvt1cNp-Ed-ak6NoX_4Aeg_-1625631819")]
    [DisplayName("Switch Order Leg Identification")]
    [IsoXmlTag("SwtchOrdrLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SwitchOrderLegIdentification { get; init; }
}
