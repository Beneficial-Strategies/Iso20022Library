// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product to purchase.
/// </summary>
[IsoId("_9iyJUJVZEeWuuIjj4l7kpg")]
[DisplayName("Product")]
public partial record Product4
{
    #nullable enable
    
    /// <summary>
    /// Product code.
    /// </summary>
    [IsoId("_-YPKo5VZEeWuuIjj4l7kpg")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; } 
    
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_-YPKpZVZEeWuuIjj4l7kpg")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    
    
    #nullable disable
    
}
