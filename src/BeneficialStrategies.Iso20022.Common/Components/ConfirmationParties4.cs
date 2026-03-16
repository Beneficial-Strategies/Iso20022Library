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
[IsoId("_AeLmRNokEeC60axPepSq7g_-324873963")]
[DisplayName("Confirmation Parties")]
public record ConfirmationParties4
{
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_AeLmRdokEeC60axPepSq7g_-1648850605")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentificationAndAccount79? Investor { get; init; }

    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AeLmRtokEeC60axPepSq7g_-146755291")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ConfirmationPartyDetails2? Buyer { get; init; }

    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_AeLmR9okEeC60axPepSq7g_-1755117827")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public ConfirmationPartyDetails2? Borrower { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AeUwMNokEeC60axPepSq7g_-1321946316")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ConfirmationPartyDetails2? Seller { get; init; }

    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_AeUwMdokEeC60axPepSq7g_-109850392")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public ConfirmationPartyDetails2? Lender { get; init; }

    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_AeUwMtokEeC60axPepSq7g_323321119")]
    [DisplayName("Broker Of Credit")]
    [IsoXmlTag("BrkrOfCdt")]
    public ConfirmationPartyDetails3? BrokerOfCredit { get; init; }

    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_AeUwM9okEeC60axPepSq7g_1862109561")]
    [DisplayName("Introducing Firm")]
    [IsoXmlTag("IntrdcgFirm")]
    public ConfirmationPartyDetails3? IntroducingFirm { get; init; }

    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_AeUwNNokEeC60axPepSq7g_1156994946")]
    [DisplayName("Step In Firm")]
    [IsoXmlTag("StepInFirm")]
    public ConfirmationPartyDetails1? StepInFirm { get; init; }

    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_AeUwNdokEeC60axPepSq7g_-1830875646")]
    [DisplayName("Step Out Firm")]
    [IsoXmlTag("StepOutFirm")]
    public ConfirmationPartyDetails1? StepOutFirm { get; init; }

    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_AeUwNtokEeC60axPepSq7g_-18196079")]
    [DisplayName("Clearing Firm")]
    [IsoXmlTag("ClrFirm")]
    public ConfirmationPartyDetails6? ClearingFirm { get; init; }

    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_AeehMNokEeC60axPepSq7g_1627071356")]
    [DisplayName("Executing Broker")]
    [IsoXmlTag("ExctgBrkr")]
    public ConfirmationPartyDetails6? ExecutingBroker { get; init; }

    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_AeehMdokEeC60axPepSq7g_-249312182")]
    [DisplayName("Affirming Party")]
    [IsoXmlTag("AffrmgPty")]
    public ConfirmationPartyDetails3? AffirmingParty { get; init; }

    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    [IsoId("_AeehMtokEeC60axPepSq7g_996963158")]
    [DisplayName("Trade Beneficiary Party")]
    [IsoXmlTag("TradBnfcryPty")]
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; }
}
