// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice to define the price of the securities transaction.
/// </summary>
[IsoId("_i7VOgZiuEe2f7NHvXATP5g")]
[DisplayName("Securities Transaction Price")]
public partial record SecuritiesTransactionPrice7
{
    #nullable enable
    
    /// <summary>
    /// Price expressed as a monetary value.
    /// </summary>
    [IsoId("_i9PTAZiuEe2f7NHvXATP5g")]
    [DisplayName("Monetary Value")]
    [IsoXmlTag("MntryVal")]
    public required AmountAndDirection61 MonetaryValue { get; init; } 
    
    /// <summary>
    /// Price expressed as a number of digital tokens.
    /// </summary>
    [IsoId("_o26cIJiuEe2f7NHvXATP5g")]
    [DisplayName("Digital Token Quantity")]
    [IsoXmlTag("DgtlTknQty")]
    public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
    
    
    #nullable disable
    
}
