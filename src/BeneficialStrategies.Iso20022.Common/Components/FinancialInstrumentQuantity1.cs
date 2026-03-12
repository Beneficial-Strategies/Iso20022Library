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
[IsoId("_SoH21Np-Ed-ak6NoX_4Aeg_-1748202213")]
[DisplayName("Financial Instrument Quantity")]
public partial record FinancialInstrumentQuantity1
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Unit { get; init; } 
    
    
    #nullable disable
    
}
