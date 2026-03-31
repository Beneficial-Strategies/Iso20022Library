// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement price details.
/// </summary>
[IsoId("_1gVSBDL3EeKU9IrkkToqcw_-1227345487")]
[DisplayName("Corporate Action Price SD")]
public record CorporateActionPriceSD2
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1gVSBTL3EeKU9IrkkToqcw_-229665491")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Price and currency at which cash will be paid for fractional shares (cash-in-lieu rate) by DTC (The Depository Trust Corporation). Used in conjunction with a rounding factor element.
    /// </summary>
    [IsoId("_1gfDADL3EeKU9IrkkToqcw_1074084746")]
    [DisplayName("DTC Cash In Lieu Price")]
    [IsoXmlTag("DTCCshInLieuPric")]
    public RateAndAmountFormat17Choice_? DTCCashInLieuPrice { get; init; }
}
