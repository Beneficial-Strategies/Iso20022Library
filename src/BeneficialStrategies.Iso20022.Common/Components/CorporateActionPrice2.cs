// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
[IsoId("_TgmW99p-Ed-ak6NoX_4Aeg_-1746744860")]
[DisplayName("Corporate Action Price")]
public partial record CorporateActionPrice2
{
    #nullable enable
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, e.g. on a Dutch auction offer.
    /// </summary>
    [IsoId("_TgmW-Np-Ed-ak6NoX_4Aeg_885958273")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat3Choice_? MaximumPrice { get; init; } 
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, e.g. on a Dutch auction offer.
    /// </summary>
    [IsoId("_Tgvg4Np-Ed-ak6NoX_4Aeg_927515601")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat3Choice_? MinimumPrice { get; init; } 
    
    
    #nullable disable
    
}
