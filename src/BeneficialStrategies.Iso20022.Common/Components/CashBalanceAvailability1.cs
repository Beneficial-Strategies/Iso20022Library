// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest.
/// </summary>
[IsoId("_TU0k0Np-Ed-ak6NoX_4Aeg_865553727")]
[DisplayName("Cash Balance Availability")]
public partial record CashBalanceAvailability1
{
    #nullable enable
    
    /// <summary>
    /// Indicates when the amount of money will become available.
    /// </summary>
    [IsoId("_TU-VwNp-Ed-ak6NoX_4Aeg_609227725")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required CashBalanceAvailabilityDate1 Date { get; init; } 
    
    /// <summary>
    /// Identifies the available amount.
    /// </summary>
    [IsoId("_TU-Vwdp-Ed-ak6NoX_4Aeg_865553839")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the availability balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_TU-Vwtp-Ed-ak6NoX_4Aeg_1983432427")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
