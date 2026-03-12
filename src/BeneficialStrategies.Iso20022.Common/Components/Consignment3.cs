// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical packaging of goods for transport.
/// </summary>
[IsoId("_Iue04TAPEeOKib24wnHaFg")]
[DisplayName("Consignment")]
public partial record Consignment3
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of packaging units, eg number of boxes, containers, pallets, etc.
    /// </summary>
    [IsoId("_JJRTcTAPEeOKib24wnHaFg")]
    [DisplayName("Total Quantity")]
    [IsoXmlTag("TtlQty")]
    public Quantity10? TotalQuantity { get; init; } 
    
    /// <summary>
    /// Total volume of goods shipped, eg number of cubic meters.
    /// </summary>
    [IsoId("_JJRTczAPEeOKib24wnHaFg")]
    [DisplayName("Total Volume")]
    [IsoXmlTag("TtlVol")]
    public Quantity10? TotalVolume { get; init; } 
    
    /// <summary>
    /// Total weight of goods shipped, eg number of kg, tons.
    /// </summary>
    [IsoId("_JJRTdTAPEeOKib24wnHaFg")]
    [DisplayName("Total Weight")]
    [IsoXmlTag("TtlWght")]
    public Quantity10? TotalWeight { get; init; } 
    
    
    #nullable disable
    
}
