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
[IsoId("_Uu1Eptp-Ed-ak6NoX_4Aeg_-1083249158")]
[DisplayName("Individual Order Status And Reason")]
public record IndividualOrderStatusAndReason1
{
    /// <summary>
    /// Status of the order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_Uu1Ep9p-Ed-ak6NoX_4Aeg_-1083249133")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderStatus2Code Status { get; init; }

    /// <summary>
    /// Status of the individual order details is cancelled.
    /// </summary>
    [IsoId("_Uu1EqNp-Ed-ak6NoX_4Aeg_-1083248574")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus1 Cancelled { get; init; }

    /// <summary>
    /// Status of the individual order details is conditionally accepted.
    /// </summary>
    [IsoId("_Uu1Eqdp-Ed-ak6NoX_4Aeg_-1083248754")]
    [DisplayName("Conditionally Accepted")]
    [IsoXmlTag("CondlyAccptd")]
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; }

    /// <summary>
    /// Status of the individual order details is in repair.
    /// </summary>
    [IsoId("_Uu1Eqtp-Ed-ak6NoX_4Aeg_-1083248669")]
    [DisplayName("In Repair")]
    [IsoXmlTag("InRpr")]
    public required InRepairStatus1 InRepair { get; init; }

    /// <summary>
    /// Status of the individual order details is rejected.
    /// </summary>
    [IsoId("_Uu-OkNp-Ed-ak6NoX_4Aeg_-1083248712")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus3 Rejected { get; init; }

    /// <summary>
    /// Status of the individual order details is suspended.
    /// </summary>
    [IsoId("_Uu-Okdp-Ed-ak6NoX_4Aeg_-1083248807")]
    [DisplayName("Suspended")]
    [IsoXmlTag("Sspd")]
    public required SuspendedStatus1 Suspended { get; init; }

    /// <summary>
    /// Elements from the original individual order details that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_Uu-Oktp-Ed-ak6NoX_4Aeg_-1083248634")]
    [DisplayName("Repaired Conditions")]
    [IsoXmlTag("RprdConds")]
    public required RepairedConditions2 RepairedConditions { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Uu-Ok9p-Ed-ak6NoX_4Aeg_-1083249081")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uu-OlNp-Ed-ak6NoX_4Aeg_-381805168")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; }

    /// <summary>
    /// Choice between the investment account and the financial instrument.
    /// </summary>
    [IsoId("_Uu-Oldp-Ed-ak6NoX_4Aeg_-1083248185")]
    [DisplayName("Investment Account Or Financial Instrument")]
    [IsoXmlTag("InvstmtAcctOrFinInstrm")]
    public InvestmentAccountOrFinancialInstrument1Choice_? InvestmentAccountOrFinancialInstrument { get; init; }

    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    [IsoId("_Uu-Oltp-Ed-ak6NoX_4Aeg_-1083248280")]
    [DisplayName("New Details")]
    [IsoXmlTag("NewDtls")]
    public ExpectedExecutionDetails1? NewDetails { get; init; }
}
