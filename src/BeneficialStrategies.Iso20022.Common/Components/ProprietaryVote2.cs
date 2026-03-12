// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary vote type and quantity voted.
/// </summary>
[IsoId("_EarWo7qLEemCAOifqHrKJw")]
[DisplayName("Proprietary Vote")]
public partial record ProprietaryVote2
{
    #nullable enable
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_EarWpbqLEemCAOifqHrKJw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required GenericIdentification30 Code { get; init; } 
    
    /// <summary>
    /// Quantity of securities voted.
    /// </summary>
    [IsoId("_EarWpLqLEemCAOifqHrKJw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity18Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
