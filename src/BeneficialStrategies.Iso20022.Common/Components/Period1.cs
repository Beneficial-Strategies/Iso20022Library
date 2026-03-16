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
[IsoId("_T57c8tp-Ed-ak6NoX_4Aeg_-1888965198")]
[DisplayName("Period")]
public record Period1
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T57c89p-Ed-ak6NoX_4Aeg_-1861258591")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat4Choice_ StartDate { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T57c9Np-Ed-ak6NoX_4Aeg_-1861258590")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat4Choice_ EndDate { get; init; }
}
