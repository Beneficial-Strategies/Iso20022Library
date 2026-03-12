// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide security position details.
/// </summary>
[IsoId("_jKPqh-5NEeCisYr99QEiWA_1769802046")]
[DisplayName("Securities Position")]
public partial record SecuritiesPosition1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of a position or a balance, such as earmarked or delivered.
    /// </summary>
    [IsoId("_jKZbgO5NEeCisYr99QEiWA_-1820329742")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText Type { get; init; } 
    
    /// <summary>
    /// Specifies the quantity of a position or a balance.
    /// </summary>
    [IsoId("_jKZbge5NEeCisYr99QEiWA_1450583756")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity2Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
