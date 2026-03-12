// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
/// </summary>
[IsoId("_Uvt1e9p-Ed-ak6NoX_4Aeg_-1430220527")]
[DisplayName("Original Order Quantity Type")]
public partial record OriginalOrderQuantityType1
{
    #nullable enable
    
    /// <summary>
    /// Order type, expressed as a code.
    /// </summary>
    [IsoId("_Uvt1fNp-Ed-ak6NoX_4Aeg_-1000782955")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required OrderQuantityType1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the order type.
    /// </summary>
    [IsoId("_Uv3mcNp-Ed-ak6NoX_4Aeg_-997087875")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
