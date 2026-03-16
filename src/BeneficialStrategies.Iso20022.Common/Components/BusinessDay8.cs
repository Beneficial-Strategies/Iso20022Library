// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on business day information.
/// </summary>
[IsoId("_ODn9JXXyEei3jO6riKEVXg")]
[DisplayName("Business Day")]
public record BusinessDay8
{
    /// <summary>
    /// Identification of a particular market infrastructure.
    /// </summary>
    [IsoId("_ONBJs3XyEei3jO6riKEVXg")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public ValueList<SystemIdentification2Choice_> SystemIdentification { get; init; } = [];

    // ID for the above is _ONBJs3XyEei3jO6riKEVXg

    /// <summary>
    /// Requested information on the system availability for a specific business day or business error when information has not been found.
    /// </summary>
    [IsoId("_ONBJtXXyEei3jO6riKEVXg")]
    [DisplayName("Business Day Or Error")]
    [IsoXmlTag("BizDayOrErr")]
    public required BusinessDayReportOrError10Choice_ BusinessDayOrError { get; init; }
}
