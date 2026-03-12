// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit for an amount range.
/// </summary>
[IsoId("_T4ItO9p-Ed-ak6NoX_4Aeg_-1155989003")]
[DisplayName("Amount Range Boundary")]
public partial record AmountRangeBoundary1
{
    #nullable enable
    
    /// <summary>
    /// Amount value of the range limit.
    /// </summary>
    [IsoId("_T4ItPNp-Ed-ak6NoX_4Aeg_-1036855293")]
    [DisplayName("Boundary Amount")]
    [IsoXmlTag("BdryAmt")]
    public required ImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether the boundary amount is included in the range of amount values.
    /// </summary>
    [IsoId("_T4SeMNp-Ed-ak6NoX_4Aeg_-1036855240")]
    [DisplayName("Included")]
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Included { get; init; } 
    
    
    #nullable disable
    
}
