// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of an individual order of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("4a601ee9-a3e8-41ed-b9f1-030ed7ed2ec5")]
[DisplayName("Individual Order Status And Reason10")]
public record IndividualOrderStatusAndReason10
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("d962f027-e726-40b7-93ba-c692ff5affe1")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("61ca5205-c205-4bb9-9ca6-74a167304b40")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("9ef316b7-c706-46ff-96a6-74dd00f4ebc5")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("2d1f25f7-77af-4cad-ba36-014bbc084bb2")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("a7244492-eb80-4de1-839d-73f9b981de87")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    [IsoId("8cc61f9a-09b9-4224-8a17-8d1c7c2dd0a8")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public required CancellationStatus33Choice CancellationStatus { get; init; }

    /// <summary>
    /// Party that initiates the status of the individual order cancellation.
    /// </summary>
    [IsoId("556327a6-86d1-46d5-a6b1-59e6f96d9f53")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Account information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("dc59b7c0-a033-43ba-b74f-cd87692ae997")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Financial instrument information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("20d07e0a-64b1-4e02-a23c-cb018c851022")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument107? FinancialInstrumentDetails { get; init; }
}
