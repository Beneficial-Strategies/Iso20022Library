// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_8bg2V5NLEeWGlc8L7oPDIg")]
[DisplayName("Price Information")]
public partial record PriceInformation16
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_8bg2W5NLEeWGlc8L7oPDIg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice45Choice_ Type { get; init; } 
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_8bg2Y5NLEeWGlc8L7oPDIg")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_8bg2a5NLEeWGlc8L7oPDIg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown1Choice_ Value { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_8bg2c5NLEeWGlc8L7oPDIg")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification91? SourceOfPrice { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_8bg2e5NLEeWGlc8L7oPDIg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    
    
    #nullable disable
    
}
