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
[IsoId("_MNH9sb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Price SD")]
public record CorporateActionPriceSD5
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_MdCpAb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Corresponding cash in lieu price as declared on the market by issuer/ offeror.
    /// </summary>
    [IsoId("_MdCpA75XEeexmbB7KsjCwA")]
    [DisplayName("Declared Cash In Lieu Price")]
    [IsoXmlTag("DclrdCshInLieuPric")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? DeclaredCashInLieuPrice { get; init; }
}
