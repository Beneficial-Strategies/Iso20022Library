// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional amount that may be displayed to the customer, for instance the daily limit or the daily balance for the service.
/// </summary>
[IsoId("_3ACQ0a19EeWMg5rOByfExw")]
[DisplayName("ATM Transaction Amounts")]
public partial record ATMTransactionAmounts7
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_3L9M8a19EeWMg5rOByfExw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_3L9M9619EeWMg5rOByfExw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_3L9M9a19EeWMg5rOByfExw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Description of the amount that may be provided to the customer.
    /// </summary>
    [IsoId("_3L9M8619EeWMg5rOByfExw")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; } 
    
    
    #nullable disable
    
}
