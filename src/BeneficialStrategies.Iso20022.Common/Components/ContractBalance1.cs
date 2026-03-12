// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance details of a registered contract.
/// </summary>
[IsoId("_P1IeoQtKEeWkxvNyFrBT8Q")]
[DisplayName("Contract Balance")]
public partial record ContractBalance1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the contract balance.
    /// </summary>
    [IsoId("_QAvRtwtKEeWkxvNyFrBT8Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ContractBalanceType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Currency and amount of money of the contract balance.
    /// </summary>
    [IsoId("_QAvRswtKEeWkxvNyFrBT8Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_QAvRtQtKEeWkxvNyFrBT8Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebit3Code CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
