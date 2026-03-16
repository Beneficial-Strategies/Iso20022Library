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
[IsoId("_AdSOYNokEeC60axPepSq7g_-2040835565")]
[DisplayName("Confirmation Parties")]
public record ConfirmationParties3
{
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_AdSOYdokEeC60axPepSq7g_-430407444")]
    [DisplayName("Affirming Party")]
    [IsoXmlTag("AffrmgPty")]
    public required ConfirmationPartyDetails4 AffirmingParty { get; init; }

    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AdSOYtokEeC60axPepSq7g_-1862716893")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ConfirmationPartyDetails2? Buyer { get; init; }

    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_AdSOY9okEeC60axPepSq7g_-353765411")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public ConfirmationPartyDetails2? Borrower { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AdSOZNokEeC60axPepSq7g_1257059378")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ConfirmationPartyDetails2? Seller { get; init; }

    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_AdSOZdokEeC60axPepSq7g_1291502024")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public ConfirmationPartyDetails2? Lender { get; init; }

    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    [IsoId("_AdSOZtokEeC60axPepSq7g_-1364420240")]
    [DisplayName("Trade Beneficiary Party")]
    [IsoXmlTag("TradBnfcryPty")]
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; }
}
