// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Relates an amount to a period of time.
/// </summary>
[IsoId("_OTgzMzgw-AOSNFX-8224502")]
[DisplayName("Amount And Period")]
public record AmountAndPeriod1
{
    /// <summary>
    /// Amount of this period.
    /// </summary>
    [IsoId("_OTgzMzgx-AOSNFX-8224502")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Start of period or immediate if not specified.
    /// </summary>
    [IsoId("_OTgzMzgy-AOSNFX-8224502")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// End of period or indefinite if not specified.
    /// </summary>
    [IsoId("_OTgzMzgz-AOSNFX-8224502")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }
}
