// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_QfevUNp-Ed-ak6NoX_4Aeg_-1767416196")]
[DisplayName("Price Information")]
public record PriceInformation2
{
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QfevUdp-Ed-ak6NoX_4Aeg_-1767416178")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_QfevUtp-Ed-ak6NoX_4Aeg_-1767416161")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public PriceValueType2Code? ValueType { get; init; }

    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfevU9p-Ed-ak6NoX_4Aeg_-1767416136")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice11Code Type { get; init; }

    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfevVNp-Ed-ak6NoX_4Aeg_1045631543")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_QfevVdp-Ed-ak6NoX_4Aeg_-1767416101")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public PriceSourceFormatChoice_? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_QfevVtp-Ed-ak6NoX_4Aeg_-1767416075")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; }

    /// <summary>
    /// Indicates whether the price is expressed as a yield. The absence of Yielded means it is not applicable.
    /// </summary>
    [IsoId("_QfevV9p-Ed-ak6NoX_4Aeg_-1767415823")]
    [DisplayName("Yielded")]
    [IsoXmlTag("Yldd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Yielded { get; init; }
}
