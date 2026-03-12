// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates when the amount of money will become available, that is can be accessed and start generating interest.
/// </summary>
[IsoId("_VYy83zqwEeWZFYSPlduMhw")]
[DisplayName("Cash Availability")]
public partial record CashAvailability1
{
    #nullable enable
    
    /// <summary>
    /// Indicates when the amount of money will become available.
    /// </summary>
    [IsoId("_Vf2nEzqwEeWZFYSPlduMhw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required CashAvailabilityDate1Choice_ Date { get; init; } 
    
    /// <summary>
    /// Identifies the available amount.
    /// </summary>
    [IsoId("_Vf2nFTqwEeWZFYSPlduMhw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the availability balance is a credit or a debit balance. |Usage: A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_Vf2nFzqwEeWZFYSPlduMhw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
