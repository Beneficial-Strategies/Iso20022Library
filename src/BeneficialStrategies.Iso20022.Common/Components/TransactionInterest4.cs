// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details on transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_t6wQa66QEeexrtTFgmVD3Q")]
[DisplayName("Transaction Interest")]
public partial record TransactionInterest4
{
    #nullable enable
    
    /// <summary>
    /// Total amount of interests and taxes included in the entry amount.
    /// </summary>
    [IsoId("_uDYn066QEeexrtTFgmVD3Q")]
    [DisplayName("Total Interest And Tax Amount")]
    [IsoXmlTag("TtlIntrstAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalInterestAndTaxAmount { get; init; } 
    
    /// <summary>
    /// Individual interest record.
    /// </summary>
    [IsoId("_uDYn1a6QEeexrtTFgmVD3Q")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public InterestRecord2? Record { get; init; } 
    
    
    #nullable disable
    
}
