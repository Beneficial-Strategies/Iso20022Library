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
[IsoId("_U49RA9p-Ed-ak6NoX_4Aeg_-2122379247")]
[DisplayName("Price Information")]
public partial record PriceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U49RBNp-Ed-ak6NoX_4Aeg_-1294906390")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_U49RBdp-Ed-ak6NoX_4Aeg_-1379868804")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public PriceValueType2Code? ValueType { get; init; } 
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U49RBtp-Ed-ak6NoX_4Aeg_-851613313")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice5Code Type { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_U49RB9p-Ed-ak6NoX_4Aeg_-1267199751")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public PriceSourceFormatChoice_? SourceOfPrice { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_U49RCNp-Ed-ak6NoX_4Aeg_-1265350672")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the price is expressed as a yield. The absence of Yielded means it is not applicable.
    /// </summary>
    [IsoId("_U5HCANp-Ed-ak6NoX_4Aeg_-1233950935")]
    [DisplayName("Yielded")]
    [IsoXmlTag("Yldd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Yielded { get; init; } 
    
    
    #nullable disable
    
}
