// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to identify a product.
/// </summary>
[IsoId("_TRPsXdp-Ed-ak6NoX_4Aeg_-1876396278")]
[DisplayName("Product Identifier")]
public partial record ProductIdentifier2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of product identifier by means of a code.
    /// </summary>
    [IsoId("_TRZdUNp-Ed-ak6NoX_4Aeg_-1876396252")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ProductIdentifier2Code Type { get; init; } 
    
    /// <summary>
    /// Specifies the product identifier.
    /// </summary>
    [IsoId("_TRZdUdp-Ed-ak6NoX_4Aeg_-1876396236")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; } 
    
    
    #nullable disable
    
}
