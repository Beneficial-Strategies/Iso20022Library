// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_lzUMwQ0qEeK9as54HthO0w")]
[DisplayName("Quantity Breakdown")]
public partial record QuantityBreakdown23
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_mKunNQ0qEeK9as54HthO0w")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; } 
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_mKunPw0qEeK9as54HthO0w")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance4? LotQuantity { get; init; } 
    
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_mKunSQ0qEeK9as54HthO0w")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_mKunUw0qEeK9as54HthO0w")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price2? LotPrice { get; init; } 
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_mKunXQ0qEeK9as54HthO0w")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    
    
    #nullable disable
    
}
