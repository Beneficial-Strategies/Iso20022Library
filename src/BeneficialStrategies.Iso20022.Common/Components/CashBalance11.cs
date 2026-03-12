// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance details for a cash account.
/// </summary>
[IsoId("_gyBmcZ-dEee28J7y9KlTWg")]
[DisplayName("Cash Balance")]
public partial record CashBalance11
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    [IsoId("_g7aL85-dEee28J7y9KlTWg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_g7aL9Z-dEee28J7y9KlTWg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_g7aL95-dEee28J7y9KlTWg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public BalanceType9Choice_? Type { get; init; } 
    
    /// <summary>
    /// Current status of a cash balance.
    /// </summary>
    [IsoId("_g7aL-Z-dEee28J7y9KlTWg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public BalanceStatus1Code? Status { get; init; } 
    
    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_g7aL-5-dEee28J7y9KlTWg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Number of payments taken into account for the calculation of the cash balance value.
    /// </summary>
    [IsoId("_g7aL_Z-dEee28J7y9KlTWg")]
    [DisplayName("Number Of Payments")]
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPayments { get; init; } 
    
    
    #nullable disable
    
}
