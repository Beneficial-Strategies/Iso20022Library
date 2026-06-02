// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the intra-position movement status query criteria including the status period.
/// </summary>
[IsoId("_dE2QUWdHEemVjsmmE4lqKA")]
[DisplayName("Intra Position Query Status3")]
public record IntraPositionQueryStatus3
{
    /// <summary>
    /// Defines the status type of query criteria.
    /// </summary>
    [IsoId("_dZSPQWdHEemVjsmmE4lqKA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IntraPositionStatusType2 Type { get; init; }

    /// <summary>
    /// Specified date period of the status.
    /// </summary>
    [IsoId("_dZSPQ2dHEemVjsmmE4lqKA")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DateAndDateTimeSearch5Choice? DatePeriod { get; init; }
}
