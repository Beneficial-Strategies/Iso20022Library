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
[IsoId("__IB3UbPwEeelzbgsFa3sqQ")]
[DisplayName("Price Information")]
public partial record PriceInformation18
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("__XWsw7PwEeelzbgsFa3sqQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice30Choice_ Type { get; init; } 
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("__XWsy7PwEeelzbgsFa3sqQ")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("__XWs07PwEeelzbgsFa3sqQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown2Choice_ Value { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("__XWs27PwEeelzbgsFa3sqQ")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification89? SourceOfPrice { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("__XWs47PwEeelzbgsFa3sqQ")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; } 
    
    
    #nullable disable
    
}
