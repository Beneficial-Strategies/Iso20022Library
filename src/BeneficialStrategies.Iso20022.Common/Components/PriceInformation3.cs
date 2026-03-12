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
[IsoId("_Qf60NNp-Ed-ak6NoX_4Aeg_-1826849881")]
[DisplayName("Price Information")]
public partial record PriceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_Qf60Ndp-Ed-ak6NoX_4Aeg_-41080249")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_Qf60Ntp-Ed-ak6NoX_4Aeg_-311662157")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public required UnitPriceType1Choice_ PriceType { get; init; } 
    
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_Qf60N9p-Ed-ak6NoX_4Aeg_-41080187")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public PriceSourceFormatChoice_? SourceOfPrice { get; init; } 
    
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_Qf60ONp-Ed-ak6NoX_4Aeg_-41080157")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the price is expressed as a yield. The absence of Yielded means it is not applicable.
    /// </summary>
    [IsoId("_Qf60Odp-Ed-ak6NoX_4Aeg_-41080156")]
    [DisplayName("Yielded Indicator")]
    [IsoXmlTag("YlddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? YieldedIndicator { get; init; } 
    
    
    #nullable disable
    
}
