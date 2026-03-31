// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Market maker profile.
/// </summary>
[IsoId("_Zv1oMe6SEemVDc1WJaqofw")]
[DisplayName("Market Maker Profile")]
public record MarketMakerProfile2
{
    /// <summary>
    /// Period of the contract.
    /// </summary>
    [IsoId("_aDCRAe6SEemVDc1WJaqofw")]
    [DisplayName("Contract Period")]
    [IsoXmlTag("CtrctPrd")]
    public DateTimePeriod2? ContractPeriod { get; init; }

    /// <summary>
    /// Indicates whether the market maker is obligated to comply with the requirements of the contract it holds with the exchange or is exempt from these obligations.
    /// </summary>
    [IsoId("_aDCRA-6SEemVDc1WJaqofw")]
    [DisplayName("Compliance")]
    [IsoXmlTag("Cmplc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Compliance { get; init; }

    /// <summary>
    /// Percentage of the variation between the maximum accepted minimum and maximum value of an action.
    /// </summary>
    [IsoId("_aDCRBe6SEemVDc1WJaqofw")]
    [DisplayName("Maximum Spread")]
    [IsoXmlTag("MaxSprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumSpread { get; init; }

    /// <summary>
    /// Rate of discount.
    /// </summary>
    [IsoId("_aDCRB-6SEemVDc1WJaqofw")]
    [DisplayName("Discount")]
    [IsoXmlTag("Dscnt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Discount { get; init; }
}
