// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains amount details for a specific type of charge.
/// </summary>
[IsoId("_7-MslffJEei89sMSHxl1ew")]
[DisplayName("Amount")]
public partial record Amount11
{
    #nullable enable
    
    /// <summary>
    /// Type of telephone charge.
    /// </summary>
    [IsoId("_7-PI0ffJEei89sMSHxl1ew")]
    [DisplayName("Type Of Charge")]
    [IsoXmlTag("TpOfChrg")]
    public TypeOfAmount19Code? TypeOfCharge { get; init; } 
    
    /// <summary>
    /// Description of other type of charge.
    /// </summary>
    [IsoId("_7-PI0PfJEei89sMSHxl1ew")]
    [DisplayName("Other Type Of Charge")]
    [IsoXmlTag("OthrTpOfChrg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherTypeOfCharge { get; init; } 
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_7-PI0vfJEei89sMSHxl1ew")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    [IsoId("_7-PI0_fJEei89sMSHxl1ew")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    
    
    #nullable disable
    
}
