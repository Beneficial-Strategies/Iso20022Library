// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_ddRJ8WkEEeS7zPBpvm732w")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount7
{
    #nullable enable
    
    /// <summary>
    /// Cash-back amount.
    /// </summary>
    [IsoId("_dqMLoWkEEeS7zPBpvm732w")]
    [DisplayName("Cash Back")]
    [IsoXmlTag("CshBck")]
    public ImpliedCurrencyAndAmount? CashBack { get; init; } 
    
    /// <summary>
    /// Gratuity amount.
    /// </summary>
    [IsoId("_dqMLo2kEEeS7zPBpvm732w")]
    [DisplayName("Gratuity")]
    [IsoXmlTag("Grtty")]
    public ImpliedCurrencyAndAmount? Gratuity { get; init; } 
    
    /// <summary>
    /// Fees amount.
    /// </summary>
    [IsoId("_dqMLpWkEEeS7zPBpvm732w")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public DetailedAmount4? Fees { get; init; } 
    
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    [IsoId("_dqMLp2kEEeS7zPBpvm732w")]
    [DisplayName("Rebate")]
    [IsoXmlTag("Rbt")]
    public DetailedAmount4? Rebate { get; init; } 
    
    /// <summary>
    /// Value added tax amount.
    /// </summary>
    [IsoId("_dqMLqWkEEeS7zPBpvm732w")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public DetailedAmount4? ValueAddedTax { get; init; } 
    
    /// <summary>
    /// Additional charge paid by the cardholder. For example airline credit card surcharge.
    /// </summary>
    [IsoId("_m6QBwGkEEeS7zPBpvm732w")]
    [DisplayName("Surcharge")]
    [IsoXmlTag("Srchrg")]
    public DetailedAmount4? Surcharge { get; init; } 
    
    
    #nullable disable
    
}
