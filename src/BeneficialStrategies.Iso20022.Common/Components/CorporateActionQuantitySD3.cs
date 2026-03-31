// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action securities quantity details.
/// </summary>
[IsoId("_1RnrQb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Quantity SD")]
public record CorporateActionQuantitySD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_1h_Cgb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Represents &quot;subscription base&quot; (Quantity2) and &quot;subscription disbursed&quot; (Quantity1) quantity elements. &quot;Subscription base quantity&quot; is the quantity of the rights security that forms the basis for calculating the payout. It is located on the distribution announcement, with the rights subscription announcement following later. &quot;Subscription disbursed quantity&quot; is the quantity of securities received in the security payout. It is located on the distribution announcement, with the rights subscription announcement following later.
    /// </summary>
    [IsoId("_1h_Cg75WEeexmbB7KsjCwA")]
    [DisplayName("Subscription Quantity")]
    [IsoXmlTag("SbcptQty")]
    public RatioFormat23Choice_? SubscriptionQuantity { get; init; }
}
