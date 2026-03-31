// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_oTi1cQ-pEeuE0Pnt-OcNOA")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD20
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_orWRcQ-pEeuE0Pnt-OcNOA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Indicates that the underlying security is a money market instrument.
    /// </summary>
    [IsoId("_wbz9EQ-pEeuE0Pnt-OcNOA")]
    [DisplayName("Money Market Instrument Flag")]
    [IsoXmlTag("MnyMktInstrmFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MoneyMarketInstrumentFlag { get; init; }
}
