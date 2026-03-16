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
[IsoId("_TR_TNtp-Ed-ak6NoX_4Aeg_-1985802937")]
[DisplayName("Individual Order Status And Reason")]
public record IndividualOrderStatusAndReason2
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_TR_TN9p-Ed-ak6NoX_4Aeg_-561399129")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_TR_TONp-Ed-ak6NoX_4Aeg_-1985802876")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_TR_TOdp-Ed-ak6NoX_4Aeg_-561398852")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_TR_TOtp-Ed-ak6NoX_4Aeg_2140630642")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_TR_TO9p-Ed-ak6NoX_4Aeg_1512317038")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Status of the individual order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_TSJEMNp-Ed-ak6NoX_4Aeg_-1985802919")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus4Code Status { get; init; }

    /// <summary>
    /// Status of the individual order is cancelled. This status is used for an order that has been accepted or that has been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_TSJEMdp-Ed-ak6NoX_4Aeg_-1985802160")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus2 Cancelled { get; init; }

    /// <summary>
    /// Status of the individual order is conditionally accepted.
    /// </summary>
    [IsoId("_TSJEMtp-Ed-ak6NoX_4Aeg_-1985802125")]
    [DisplayName("Conditionally Accepted")]
    [IsoXmlTag("CondlyAccptd")]
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; }

    /// <summary>
    /// Status of the individual order is rejected. This status is used for an order that has not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_TSJEM9p-Ed-ak6NoX_4Aeg_-1985802048")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatus6> Rejected { get; init; } = [];

    /// <summary>
    /// Status of the individual order is suspended.
    /// </summary>
    [IsoId("_TSJENNp-Ed-ak6NoX_4Aeg_-1985801970")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    public required SuspendedStatus2 Suspended { get; init; }

    /// <summary>
    /// Status of the individual order is in repair.
    /// </summary>
    [IsoId("_TSJENdp-Ed-ak6NoX_4Aeg_-1985802083")]
    [DisplayName("In Repair")]
    [IsoXmlTag("InRpr")]
    public required InRepairStatus2 InRepair { get; init; }

    /// <summary>
    /// Status of the individual order is partially settled.
    /// </summary>
    [IsoId("_TSJENtp-Ed-ak6NoX_4Aeg_8787634")]
    [DisplayName("Partially Settled")]
    [IsoXmlTag("PrtlySttld")]
    public required PartiallySettledStatus1 PartiallySettled { get; init; }

    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_TSJEN9p-Ed-ak6NoX_4Aeg_-1985802451")]
    [DisplayName("Repaired Conditions")]
    [IsoXmlTag("RprdConds")]
    public RepairedConditions3? RepairedConditions { get; init; }

    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("_TSJEONp-Ed-ak6NoX_4Aeg_-1985801893")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }

    /// <summary>
    /// Order data.
    /// </summary>
    [IsoId("_TSJEOdp-Ed-ak6NoX_4Aeg_-1985801928")]
    [DisplayName("Order Data")]
    [IsoXmlTag("OrdrData")]
    public FundOrderData1? OrderData { get; init; }

    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    [IsoId("_TSS1MNp-Ed-ak6NoX_4Aeg_-1985802005")]
    [DisplayName("New Details")]
    [IsoXmlTag("NewDtls")]
    public ExpectedExecutionDetails2? NewDetails { get; init; }
}
