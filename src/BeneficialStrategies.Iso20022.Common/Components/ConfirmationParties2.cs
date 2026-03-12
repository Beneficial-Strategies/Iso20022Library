// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_AXehVNokEeC60axPepSq7g_-1114958869")]
[DisplayName("Confirmation Parties")]
public partial record ConfirmationParties2
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AXehVdokEeC60axPepSq7g_-936840197")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_AXnrQNokEeC60axPepSq7g_1132395204")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AXnrQdokEeC60axPepSq7g_-2112031222")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ConfirmationPartyDetails2? Seller { get; init; } 
    
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_AXnrQtokEeC60axPepSq7g_-1139848453")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public ConfirmationPartyDetails2? Lender { get; init; } 
    
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_AXnrQ9okEeC60axPepSq7g_-466763787")]
    [DisplayName("Broker Of Credit")]
    [IsoXmlTag("BrkrOfCdt")]
    public ConfirmationPartyDetails1? BrokerOfCredit { get; init; } 
    
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_AXnrRNokEeC60axPepSq7g_1072024655")]
    [DisplayName("Introducing Firm")]
    [IsoXmlTag("IntrdcgFirm")]
    public ConfirmationPartyDetails1? IntroducingFirm { get; init; } 
    
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_AXnrRdokEeC60axPepSq7g_366910040")]
    [DisplayName("Step In Firm")]
    [IsoXmlTag("StepInFirm")]
    public ConfirmationPartyDetails1? StepInFirm { get; init; } 
    
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_AXnrRtokEeC60axPepSq7g_1839089819")]
    [DisplayName("Step Out Firm")]
    [IsoXmlTag("StepOutFirm")]
    public ConfirmationPartyDetails1? StepOutFirm { get; init; } 
    
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_AXxcQNokEeC60axPepSq7g_-808280985")]
    [DisplayName("Clearing Firm")]
    [IsoXmlTag("ClrFirm")]
    public ConfirmationPartyDetails5? ClearingFirm { get; init; } 
    
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_AXxcQdokEeC60axPepSq7g_836986450")]
    [DisplayName("Executing Broker")]
    [IsoXmlTag("ExctgBrkr")]
    public ConfirmationPartyDetails5? ExecutingBroker { get; init; } 
    
    /// <summary>
    /// Party sending the message to the CMU (Central Matching Utility) to identify the actual business unit as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_AXxcQtokEeC60axPepSq7g_-1919192404")]
    [DisplayName("CMU Party")]
    [IsoXmlTag("CMUPty")]
    public ConfirmationPartyDetails1? CMUParty { get; init; } 
    
    /// <summary>
    /// Actual business unit of the counterparty to the sender of the message to the CMU (Central Matching Utility) as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_AXxcQ9okEeC60axPepSq7g_1670660277")]
    [DisplayName("CMU Counterparty")]
    [IsoXmlTag("CMUCtrPty")]
    public ConfirmationPartyDetails1? CMUCounterparty { get; init; } 
    
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_AXxcRNokEeC60axPepSq7g_495469252")]
    [DisplayName("Affirming Party")]
    [IsoXmlTag("AffrmgPty")]
    public ConfirmationPartyDetails1? AffirmingParty { get; init; } 
    
    /// <summary>
    /// Party involved in a legal proceeding, agreement or other transaction.
    /// </summary>
    [IsoId("_AXxcRdokEeC60axPepSq7g_-468304836")]
    [DisplayName("Trade Beneficiary Party")]
    [IsoXmlTag("TradBnfcryPty")]
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    
    
    #nullable disable
    
}
