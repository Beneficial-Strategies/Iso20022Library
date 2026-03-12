// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_JSKGfef6Eei5aPS232E3Mw")]
[DisplayName("Securities Quantity SD")]
public partial record SecuritiesQuantitySD6
{
    #nullable enable
    
    /// <summary>
    /// Quantity not fully covered.
    /// </summary>
    [IsoId("_J0O4t-f6Eei5aPS232E3Mw")]
    [DisplayName("Open Uncovered Quantity")]
    [IsoXmlTag("OpnUcvrdQty")]
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; init; } 
    
    /// <summary>
    /// Quantity covered but transactions not in &quot;MADE&quot; status.
    /// </summary>
    [IsoId("_J0O4uef6Eei5aPS232E3Mw")]
    [DisplayName("Interim Covered Quantity")]
    [IsoXmlTag("IntrmCvrdQty")]
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; } 
    
    
    #nullable disable
    
}
