// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_O_mxO5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Active Currency And Amount Range")]
public partial record ActiveCurrencyAndAmountRange3
{
    #nullable enable
    
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    [IsoId("_PHbQc5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    [IsoId("_PHbQdZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    [IsoId("_PHbQd5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    
    #nullable disable
    
}
