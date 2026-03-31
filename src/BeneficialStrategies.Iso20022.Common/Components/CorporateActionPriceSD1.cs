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
[IsoId("_1gVSATL3EeKU9IrkkToqcw_1218900887")]
[DisplayName("Corporate Action Price SD")]
public record CorporateActionPriceSD1
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1gVSAjL3EeKU9IrkkToqcw_654415216")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Corresponding cash in lieu price as declared on the market by issuer/ offeror.
    /// </summary>
    [IsoId("_1gVSAzL3EeKU9IrkkToqcw_551316492")]
    [DisplayName("Declared Cash In Lieu Price")]
    [IsoXmlTag("DclrdCshInLieuPric")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? DeclaredCashInLieuPrice { get; init; }
}
