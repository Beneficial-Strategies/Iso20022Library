// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders confirmation that was previously received.
/// </summary>
[IsoId("e625fe64-e768-4881-b413-a879e4f5713b")]
[DisplayName("Individual Order Confirmation Status And Reason3")]
public record IndividualOrderConfirmationStatusAndReason3
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("1eb5ba7e-8fb9-454a-a0de-d7a0be4678cb")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("647f2ffa-9525-4074-97ad-decd97a4045f")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Status of the order confirmation cancellation.
    /// </summary>
    [IsoId("a7d984c1-4ad3-4dbd-b1a0-de8e28ef3b40")]
    [DisplayName("Confirmation")]
    [IsoXmlTag("Conf")]
    public required ConfirmationStatus1Choice Confirmation { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of an order.
    /// </summary>
    [IsoId("cab6aaf3-b1da-4944-ae1a-c9f3707a7590")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("90837be8-61d4-41e0-a436-58fa433c4c9c")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("15ef5add-25d0-4a2e-8f64-a523eaec8471")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Party that initiates the status of the order confirmation.
    /// </summary>
    [IsoId("c7704230-2cd4-4b88-a357-a47c72778a77")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Account information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("28d40cb7-c81e-41fe-9e8b-cd479b560863")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Financial instrument information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("3acf4512-c459-4d01-9a4b-80d5649a3bc7")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument107? FinancialInstrumentDetails { get; init; }
}
