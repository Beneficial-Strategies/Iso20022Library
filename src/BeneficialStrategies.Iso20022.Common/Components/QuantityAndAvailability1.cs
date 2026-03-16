// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_QZhRR9p-Ed-ak6NoX_4Aeg_-987951378")]
[DisplayName("Quantity And Availability")]
public record QuantityAndAvailability1
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QZhRSNp-Ed-ak6NoX_4Aeg_-987951353")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Indicates whether the quantity of securities on the sub-balance is available.
    /// </summary>
    [IsoId("_QZqbMNp-Ed-ak6NoX_4Aeg_-987951336")]
    [DisplayName("Availability Indicator")]
    [IsoXmlTag("AvlbtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AvailabilityIndicator { get; init; }
}
