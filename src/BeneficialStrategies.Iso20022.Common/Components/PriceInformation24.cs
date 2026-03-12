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
[IsoId("_sanRG_fZEeiNZp_PtLohLw")]
[DisplayName("Price Information")]
public partial record PriceInformation24
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_sanRH_fZEeiNZp_PtLohLw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice49Choice_ Type { get; init; } 
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_sanRJ_fZEeiNZp_PtLohLw")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_sanRL_fZEeiNZp_PtLohLw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown3Choice_ Value { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_sanRN_fZEeiNZp_PtLohLw")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification91? SourceOfPrice { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_sanRP_fZEeiNZp_PtLohLw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; } 
    
    
    #nullable disable
    
}
