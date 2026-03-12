// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loan offered by a group of lenders (called a syndicate) who work together to lend an amount of money to a single borrower.
/// </summary>
[IsoId("_JtldpW49EeiU9cctagi5ow")]
[DisplayName("Syndicated Loan")]
public partial record SyndicatedLoan2
{
    #nullable enable
    
    /// <summary>
    /// Party which obtains the loan.
    /// </summary>
    [IsoId("_J3au8249EeiU9cctagi5ow")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required TradeParty5 Borrower { get; init; } 
    
    /// <summary>
    /// Party which provides an amount of money available to others to borrow.
    /// </summary>
    [IsoId("_J3au9W49EeiU9cctagi5ow")]
    [DisplayName("Lender")]
    [IsoXmlTag("Lndr")]
    public TradeParty5? Lender { get; init; } 
    
    /// <summary>
    /// Amount of the part in the syndicated loan.
    /// </summary>
    [IsoId("_J3au9249EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Share of the part in the syndicated loan.
    /// </summary>
    [IsoId("_J3au-W49EeiU9cctagi5ow")]
    [DisplayName("Share")]
    [IsoXmlTag("Shr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Share { get; init; } 
    
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_J3au-249EeiU9cctagi5ow")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    
    
    #nullable disable
    
}
