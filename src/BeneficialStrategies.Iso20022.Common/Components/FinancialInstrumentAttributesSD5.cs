// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement security details.
/// </summary>
[IsoId("_1g7u8TL3EeKU9IrkkToqcw_1034011765")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD5
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1g7u8jL3EeKU9IrkkToqcw_36939412")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Matching security identifier for the disbursed security that is used to match the customer&apos;s SOI (Security of Interest) to the GCA VS Security Cross Reference.
    /// </summary>
    [IsoId("_1g7u8zL3EeKU9IrkkToqcw_-1838940768")]
    [DisplayName("Security Of Interest Matching Security")]
    [IsoXmlTag("SctyOfIntrstMtchgScty")]
    public SecurityIdentification15? SecurityOfInterestMatchingSecurity { get; init; }
}
