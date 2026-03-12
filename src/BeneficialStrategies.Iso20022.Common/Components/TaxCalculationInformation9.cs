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
[IsoId("_a-ynQUUVEea21qTBwbMSEA")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation9
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    [IsoId("_bXVqI0UVEea21qTBwbMSEA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public required TaxBasis1Choice_ Basis { get; init; } 
    
    
    #nullable disable
    
}
