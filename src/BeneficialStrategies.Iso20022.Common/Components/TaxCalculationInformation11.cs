// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate a tax.
/// </summary>
[IsoId("_oFnOEYjOEeeiYZ2e3mpBRA")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation11
{
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss.
    /// </summary>
    [IsoId("_oUxrc4jOEeeiYZ2e3mpBRA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Amount of money on which the tax is charged.
    /// </summary>
    [IsoId("_oUxrdYjOEeeiYZ2e3mpBRA")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public required ActiveCurrencyAndAmount TaxableAmount { get; init; } 
    
    
    #nullable disable
    
}
