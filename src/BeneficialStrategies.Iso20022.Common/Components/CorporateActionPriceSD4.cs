// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details price details.
/// </summary>
[IsoId("_KAVaMb5QEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Price SD")]
public record CorporateActionPriceSD4
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_KQjAcb5QEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Cost to subscribe to additional share(s) of the underlying security.
    /// </summary>
    [IsoId("_KQjAc75QEeexmbB7KsjCwA")]
    [DisplayName("Subscription Price")]
    [IsoXmlTag("SbcptPric")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? SubscriptionPrice { get; init; }
}
