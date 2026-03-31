// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fixed rate related information.
/// </summary>
[IsoId("_mNXX0fOFEeaS7fYULSI4_Q")]
[DisplayName("Fixed Rate")]
public record FixedRate6
{
    /// <summary>
    /// An indication of the fixed rate used.
    /// </summary>
    [IsoId("_mY0Z4_OFEeaS7fYULSI4_Q")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Actual number of days in the relevant fixed rate calculation period.
    /// </summary>
    [IsoId("_mY0Z5fOFEeaS7fYULSI4_Q")]
    [DisplayName("Day Count")]
    [IsoXmlTag("DayCnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DayCount { get; init; }

    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    [IsoId("_mY0Z5_OFEeaS7fYULSI4_Q")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public InterestRateFrequency2Choice_? PaymentFrequency { get; init; }
}
