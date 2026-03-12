// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a proprietary price.
/// </summary>
[IsoId("_Rpr4pNp-Ed-ak6NoX_4Aeg_1562404369")]
[DisplayName("Proprietary Price")]
public partial record ProprietaryPrice2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price.
    /// </summary>
    [IsoId("_Rpr4pdp-Ed-ak6NoX_4Aeg_1562404617")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [IsoId("_Rpr4ptp-Ed-ak6NoX_4Aeg_1562404671")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public required ActiveOrHistoricCurrencyAndAmount Price { get; init; } 
    
    
    #nullable disable
    
}
