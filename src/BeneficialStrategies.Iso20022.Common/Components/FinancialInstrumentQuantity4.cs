// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of a security.
/// </summary>
[IsoId("_WNJcx9p-Ed-ak6NoX_4Aeg_-1314429173")]
[DisplayName("Financial Instrument Quantity")]
public partial record FinancialInstrumentQuantity4
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_WNJcyNp-Ed-ak6NoX_4Aeg_-1314429142")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Unit { get; init; } 
    
    
    #nullable disable
    
}
