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
[IsoId("_hv4QUY-iEeaEa8S_GI1QNA")]
[DisplayName("Confirmation Parties")]
public record ConfirmationParties6
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_h-wZ0Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ConfirmationPartyDetails7? Buyer { get; init; }

    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_h-wZ04-iEeaEa8S_GI1QNA")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public ConfirmationPartyDetails7? Borrower { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_h-wZ1Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ConfirmationPartyDetails7? Seller { get; init; }

    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_h-wZ14-iEeaEa8S_GI1QNA")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public ConfirmationPartyDetails7? Lender { get; init; }

    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_h-wZ2Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Broker Of Credit")]
    [IsoXmlTag("BrkrOfCdt")]
    public ConfirmationPartyDetails8? BrokerOfCredit { get; init; }

    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_h-wZ24-iEeaEa8S_GI1QNA")]
    [DisplayName("Introducing Firm")]
    [IsoXmlTag("IntrdcgFirm")]
    public ConfirmationPartyDetails8? IntroducingFirm { get; init; }

    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_h-wZ3Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Step In Firm")]
    [IsoXmlTag("StepInFirm")]
    public ConfirmationPartyDetails8? StepInFirm { get; init; }

    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_h-wZ34-iEeaEa8S_GI1QNA")]
    [DisplayName("Step Out Firm")]
    [IsoXmlTag("StepOutFirm")]
    public ConfirmationPartyDetails8? StepOutFirm { get; init; }

    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_h-wZ4Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Clearing Firm")]
    [IsoXmlTag("ClrFirm")]
    public ConfirmationPartyDetails9? ClearingFirm { get; init; }

    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_h-wZ44-iEeaEa8S_GI1QNA")]
    [DisplayName("Executing Broker")]
    [IsoXmlTag("ExctgBrkr")]
    public ConfirmationPartyDetails9? ExecutingBroker { get; init; }

    /// <summary>
    /// Party sending the message to the CMU (Central Matching Utility) to identify the actual business unit as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_h-wZ5Y-iEeaEa8S_GI1QNA")]
    [DisplayName("CMU Party")]
    [IsoXmlTag("CMUPty")]
    public ConfirmationPartyDetails8? CMUParty { get; init; }

    /// <summary>
    /// Actual business unit of the counterparty to the sender of the message to the CMU (Central Matching Utility) as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_h-wZ54-iEeaEa8S_GI1QNA")]
    [DisplayName("CMU Counterparty")]
    [IsoXmlTag("CMUCtrPty")]
    public ConfirmationPartyDetails8? CMUCounterparty { get; init; }

    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_h-wZ6Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Affirming Party")]
    [IsoXmlTag("AffrmgPty")]
    public ConfirmationPartyDetails8? AffirmingParty { get; init; }

    /// <summary>
    /// Party involved in a legal proceeding, agreement or other transaction.
    /// </summary>
    [IsoId("_h-wZ64-iEeaEa8S_GI1QNA")]
    [DisplayName("Trade Beneficiary Party")]
    [IsoXmlTag("TradBnfcryPty")]
    public ConfirmationPartyDetails10? TradeBeneficiaryParty { get; init; }
}
