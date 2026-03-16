// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_WPktUwasEe2phaVG0lYKTw")]
[DisplayName("Confirmation Parties")]
public record ConfirmationParties7
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_WhAbYQasEe2phaVG0lYKTw")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ConfirmationPartyDetails12? Buyer { get; init; }

    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_WhAbYwasEe2phaVG0lYKTw")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public ConfirmationPartyDetails12? Borrower { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_WhAbZQasEe2phaVG0lYKTw")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ConfirmationPartyDetails12? Seller { get; init; }

    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_WhAbZwasEe2phaVG0lYKTw")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public ConfirmationPartyDetails12? Lender { get; init; }

    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_WhAbaQasEe2phaVG0lYKTw")]
    [DisplayName("Broker Of Credit")]
    [IsoXmlTag("BrkrOfCdt")]
    public ConfirmationPartyDetails11? BrokerOfCredit { get; init; }

    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_WhAbawasEe2phaVG0lYKTw")]
    [DisplayName("Introducing Firm")]
    [IsoXmlTag("IntrdcgFirm")]
    public ConfirmationPartyDetails11? IntroducingFirm { get; init; }

    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_WhAbbQasEe2phaVG0lYKTw")]
    [DisplayName("Step In Firm")]
    [IsoXmlTag("StepInFirm")]
    public ConfirmationPartyDetails11? StepInFirm { get; init; }

    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_WhAbbwasEe2phaVG0lYKTw")]
    [DisplayName("Step Out Firm")]
    [IsoXmlTag("StepOutFirm")]
    public ConfirmationPartyDetails11? StepOutFirm { get; init; }

    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_WhAbcQasEe2phaVG0lYKTw")]
    [DisplayName("Clearing Firm")]
    [IsoXmlTag("ClrFirm")]
    public ConfirmationPartyDetails13? ClearingFirm { get; init; }

    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_WhAbcwasEe2phaVG0lYKTw")]
    [DisplayName("Executing Broker")]
    [IsoXmlTag("ExctgBrkr")]
    public ConfirmationPartyDetails13? ExecutingBroker { get; init; }

    /// <summary>
    /// Party sending the message to the CMU (Central Matching Utility) to identify the actual business unit as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_WhAbdQasEe2phaVG0lYKTw")]
    [DisplayName("CMU Party")]
    [IsoXmlTag("CMUPty")]
    public ConfirmationPartyDetails11? CMUParty { get; init; }

    /// <summary>
    /// Actual business unit of the counterparty to the sender of the message to the CMU (Central Matching Utility) as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_WhAbdwasEe2phaVG0lYKTw")]
    [DisplayName("CMU Counterparty")]
    [IsoXmlTag("CMUCtrPty")]
    public ConfirmationPartyDetails11? CMUCounterparty { get; init; }

    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_WhAbeQasEe2phaVG0lYKTw")]
    [DisplayName("Affirming Party")]
    [IsoXmlTag("AffrmgPty")]
    public ConfirmationPartyDetails11? AffirmingParty { get; init; }

    /// <summary>
    /// Party involved in a legal proceeding, agreement or other transaction.
    /// </summary>
    [IsoId("_WhAbewasEe2phaVG0lYKTw")]
    [DisplayName("Trade Beneficiary Party")]
    [IsoXmlTag("TradBnfcryPty")]
    public ConfirmationPartyDetails14? TradeBeneficiaryParty { get; init; }
}
