// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary quantity.
/// </summary>
[IsoId("_RUhg9tp-Ed-ak6NoX_4Aeg_-1425714284")]
[DisplayName("Proprietary Quantity")]
public partial record ProprietaryQuantity1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    [IsoId("_RUhg99p-Ed-ak6NoX_4Aeg_-1425714266")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Provides the proprietary quantity in free format.
    /// </summary>
    [IsoId("_RUrR8Np-Ed-ak6NoX_4Aeg_1280200217")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Quantity { get; init; } 
    
    
    #nullable disable
    
}
