// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate type and a percentage rate.
/// </summary>
[IsoId("__Q79h0EIEeWVgfuHGaKtRQ")]
[DisplayName("Rate Type And Percentage Rate")]
public record RateTypeAndPercentageRate8
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("__c_ccUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType42Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    [IsoId("__c_cc0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
