// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders of a bulk or multiple order that was previously received.
/// </summary>
[IsoId("_TRsYQ9p-Ed-ak6NoX_4Aeg_-871439677")]
[DisplayName("Switch Order Status And Reason")]
public record SwitchOrderStatusAndReason1
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_TRsYRNp-Ed-ak6NoX_4Aeg_492338280")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_TRsYRdp-Ed-ak6NoX_4Aeg_-871439617")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_TRsYRtp-Ed-ak6NoX_4Aeg_492338323")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_TRsYR9p-Ed-ak6NoX_4Aeg_-921439186")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_TRsYSNp-Ed-ak6NoX_4Aeg_1867873909")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Status of the switch order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_TR2JQNp-Ed-ak6NoX_4Aeg_-871439635")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus4Code Status { get; init; }

    /// <summary>
    /// Status of the switch order is cancelled. This status is used for an order that has been accepted or that has been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_TR2JQdp-Ed-ak6NoX_4Aeg_-871439531")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus2 Cancelled { get; init; }

    /// <summary>
    /// Status of the switch order is conditionally accepted.
    /// </summary>
    [IsoId("_TR2JQtp-Ed-ak6NoX_4Aeg_-871439279")]
    [DisplayName("Conditionally Accepted")]
    [IsoXmlTag("CondlyAccptd")]
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; }

    /// <summary>
    /// Status of the switch order is rejected.
    /// </summary>
    [IsoId("_TR2JQ9p-Ed-ak6NoX_4Aeg_-871439184")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatus6> Rejected { get; init; } = [];

    /// <summary>
    /// Status of the switch order is suspended.
    /// </summary>
    [IsoId("_TR2JRNp-Ed-ak6NoX_4Aeg_-871439107")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    public required SuspendedStatus2 Suspended { get; init; }

    /// <summary>
    /// Status of the switch order is in repair.
    /// </summary>
    [IsoId("_TR2JRdp-Ed-ak6NoX_4Aeg_-871439219")]
    [DisplayName("In Repair")]
    [IsoXmlTag("InRpr")]
    public required InRepairStatus2 InRepair { get; init; }

    /// <summary>
    /// Status of the switch order is partially settled.
    /// </summary>
    [IsoId("_TR2JRtp-Ed-ak6NoX_4Aeg_1242877479")]
    [DisplayName("Partially Settled")]
    [IsoXmlTag("PrtlySttld")]
    public required PartiallySettledStatus1 PartiallySettled { get; init; }

    /// <summary>
    /// Information about a switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_TR2JR9p-Ed-ak6NoX_4Aeg_-31894611")]
    [DisplayName("Leg Information")]
    [IsoXmlTag("LegInf")]
    public ValueList<SwitchLegReferences1> LegInformation { get; init; } = [];

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_TR_TMNp-Ed-ak6NoX_4Aeg_-871438781")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }

    /// <summary>
    /// Order data.
    /// </summary>
    [IsoId("_TR_TMdp-Ed-ak6NoX_4Aeg_-1779352260")]
    [DisplayName("Order Data")]
    [IsoXmlTag("OrdrData")]
    public FundOrderData2? OrderData { get; init; }

    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    [IsoId("_TR_TMtp-Ed-ak6NoX_4Aeg_-871439142")]
    [DisplayName("New Details")]
    [IsoXmlTag("NewDtls")]
    public ExpectedExecutionDetails2? NewDetails { get; init; }
}
