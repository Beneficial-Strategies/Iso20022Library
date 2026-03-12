// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_HG95hcWFEeiRga8tPu1L4Q")]
[DisplayName("Position Set Total")]
public partial record PositionSetTotal1
{
    #nullable enable
    
    /// <summary>
    /// Refers to the number of trades contained in the position set.
    /// </summary>
    [IsoId("_HG95hsWFEeiRga8tPu1L4Q")]
    [DisplayName("Number Of Trades")]
    [IsoXmlTag("NbOfTrds")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public IsoMax20PositiveNumber? NumberOfTrades { get; init; } 
    
    /// <summary>
    /// Aggregations of all positive values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_HG95k8WFEeiRga8tPu1L4Q")]
    [DisplayName("Positive")]
    [IsoXmlTag("Postv")]
    public PositionSetValueAndNotional1? Positive { get; init; } 
    
    /// <summary>
    /// Aggregations of all negative values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_HG95jcWFEeiRga8tPu1L4Q")]
    [DisplayName("Negative")]
    [IsoXmlTag("Neg")]
    public PositionSetValueAndNotional1? Negative { get; init; } 
    
    
    #nullable disable
    
}
