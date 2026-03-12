// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
[IsoId("_otJa8WVREeaL1uBLI51YHQ")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation10
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    [IsoId("_pHB6k2VREeaL1uBLI51YHQ")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Amount of money on which the tax is charged.
    /// </summary>
    [IsoId("_pHB6lWVREeaL1uBLI51YHQ")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public required ActiveCurrencyAndAmount TaxableAmount { get; init; } 
    
    
    #nullable disable
    
}
