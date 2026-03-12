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
[IsoId("_VSSXA9p-Ed-ak6NoX_4Aeg_1013966021")]
[DisplayName("Tax Calculation Information")]
public partial record TaxCalculationInformation1
{
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_VSSXBNp-Ed-ak6NoX_4Aeg_-1422873809")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis1? Basis { get; init; } 
    
    
    #nullable disable
    
}
