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
[IsoId("__y4bwTAiEeOUGqA1wUwNLA")]
[DisplayName("Price Information")]
public partial record PriceInformation11
{
    #nullable enable
    
    /// <summary>
    /// Value of the price, for instance, as a currency and value.
    /// </summary>
    [IsoId("_AJ8Q4zAjEeOUGqA1wUwNLA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required Price4 Value { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_AJ8Q5TAjEeOUGqA1wUwNLA")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime1Choice_? QuotationDate { get; init; } 
    
    /// <summary>
    /// Period during which the price of a security is determined (For outturn securities).
    /// </summary>
    [IsoId("_AJ8Q7TAjEeOUGqA1wUwNLA")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public DateTimePeriodChoice_? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_AJ8Q7zAjEeOUGqA1wUwNLA")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification79? SourceOfPrice { get; init; } 
    
    
    #nullable disable
    
}
