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
[IsoId("_SnOe8Np-Ed-ak6NoX_4Aeg_1829579688")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation7
{
    #nullable enable
    
    /// <summary>
    /// Calculation basis.
    /// </summary>
    [IsoId("_SnOe8dp-Ed-ak6NoX_4Aeg_566010243")]
    [DisplayName("Tax Calculation Basis")]
    [IsoXmlTag("TaxClctnBsis")]
    public TaxCalculationBasisType1Choice_? TaxCalculationBasis { get; init; } 
    
    /// <summary>
    /// Amount of money that it is to be taxed.
    /// </summary>
    [IsoId("_SnOe8tp-Ed-ak6NoX_4Aeg_1830499782")]
    [DisplayName("Taxable Amount")]
    [IsoXmlTag("TaxblAmt")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; init; } 
    
    
    #nullable disable
    
}
