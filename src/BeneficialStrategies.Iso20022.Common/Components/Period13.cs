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
[IsoId("_HDCAEckbEee7W-rN1yqPMg")]
[DisplayName("Period")]
public record Period13
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_HVVRAckbEee7W-rN1yqPMg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat47Choice_ StartDate { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_HVVRA8kbEee7W-rN1yqPMg")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat47Choice_ EndDate { get; init; }
}
