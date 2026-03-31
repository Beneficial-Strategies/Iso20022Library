// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_4LqCYfZFEd-2Jsl2KtUQCw")]
[DisplayName("Period")]
public record Period5
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_4LzMUfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat21Choice_ StartDate { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_4LzMU_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat21Choice_ EndDate { get; init; }
}
