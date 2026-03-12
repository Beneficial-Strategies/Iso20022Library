// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Allows to specify other collateral type by providing a description and the quantity.
/// </summary>
[IsoId("_dkcYoSqUEeyR9JrVGfaMKw")]
[DisplayName("Other Type Of Collateral")]
public partial record OtherTypeOfCollateral3
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the collateral.
    /// </summary>
    [IsoId("_eI8z4SqUEeyR9JrVGfaMKw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Description { get; init; } 
    
    /// <summary>
    /// Quantity of other collateral.
    /// </summary>
    [IsoId("_eI8z4yqUEeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity33Choice_? Quantity { get; init; } 
    
    
    #nullable disable
    
}
