// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Syndicated Loan3.
/// </summary>
[IsoId("_2Vi35zEyEe6g-ffJsqGiSA")]
[DisplayName("Syndicated Loan3")]
public record SyndicatedLoan3
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Borrower.
    /// </summary>
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required TradeParty6 Borrower { get; init; }

    /// <summary>
    /// Exchange Rate Information.
    /// </summary>
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Lender.
    /// </summary>
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public TradeParty6? Lender { get; init; }

    /// <summary>
    /// Share.
    /// </summary>
    [DisplayName("Share")]
    [IsoXmlTag("Shr")]
    public IsoPercentageRate? Share { get; init; }
}
