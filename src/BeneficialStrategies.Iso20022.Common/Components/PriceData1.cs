// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the details of the price applicable to the derivative transaction.
/// </summary>
[IsoId("_hM_uQHizEeqKjIYaFgh_2g")]
[DisplayName("Price Data")]
public partial record PriceData1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    [IsoId("_nPhRYXizEeqKjIYaFgh_2g")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with prices varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_olN5AXizEeqKjIYaFgh_2g")]
    [DisplayName("Price Schedule")]
    [IsoXmlTag("PricSchdl")]
    public Schedule1? PriceSchedule { get; init; } 
    
    /// <summary>
    /// Specifies the unit of measure in which the price is expressed.
    /// </summary>
    [IsoId("_N--_EX_3EeqdQubSe21TTw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure12Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [IsoId("_p2moYXizEeqKjIYaFgh_2g")]
    [DisplayName("Price Multiplier")]
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? PriceMultiplier { get; init; } 
    
    
    #nullable disable
    
}
