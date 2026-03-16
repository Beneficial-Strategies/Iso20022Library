// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loan offered by a group of lenders (called a syndicate) who work together to lend an amount of money to a single borrower.
/// </summary>
[IsoId("_0lm3AdOKEeSQ_-lmj1tzfw")]
[DisplayName("Syndicated Loan")]
public record SyndicatedLoan1
{
    /// <summary>
    /// Party which obtains the loan.
    /// </summary>
    [IsoId("_DsfWkNOLEeSQ_-lmj1tzfw")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required TradeParty2 Borrower { get; init; }

    /// <summary>
    /// Party which provides an amount of money available to others to borrow.
    /// </summary>
    [IsoId("_OmeSE-AnEeS-z4mncO1qQg")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public TradeParty2? Lender { get; init; }

    /// <summary>
    /// Amount of the part in the syndicated loan.
    /// </summary>
    [IsoId("_zxakgNOLEeSQ_-lmj1tzfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Share of the part in the syndicated loan.
    /// </summary>
    [IsoId("_4p1sAtOLEeSQ_-lmj1tzfw")]
    [DisplayName("Share")]
    [IsoXmlTag("Shr")]
    [IsoSimpleType(IsoSimpleType.Percentage)]
    public IsoPercentage? Share { get; init; }

    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_sLJEwdONEeSQ_-lmj1tzfw")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }
}
