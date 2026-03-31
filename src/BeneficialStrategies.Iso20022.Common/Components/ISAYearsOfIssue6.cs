// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_3gg5VEXfEeGY6MkiuzuPOA_-1852894636")]
[DisplayName("ISA Years Of Issue")]
public record ISAYearsOfIssue6
{
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gqDQEXfEeGY6MkiuzuPOA_-1966733702")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    public CurrentYearType2Choice_? CurrentYear { get; init; }

    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gqDQUXfEeGY6MkiuzuPOA_334088888")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYearChoice_? PreviousYears { get; init; }
}
