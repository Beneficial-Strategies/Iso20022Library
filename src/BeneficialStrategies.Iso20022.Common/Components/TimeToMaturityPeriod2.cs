// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the start and end time for the time to maturity.
/// </summary>
[IsoId("__aOTla5OEeuo-IflVgGqiA")]
[DisplayName("Time To Maturity Period")]
public record TimeToMaturityPeriod2
{
    /// <summary>
    /// Specifies the start of the maturity period.
    /// </summary>
    [IsoId("__pHrMa5OEeuo-IflVgGqiA")]
    [DisplayName("Start")]
    [IsoXmlTag("Start")]
    public MaturityTerm2? Start { get; init; }

    /// <summary>
    /// Specifies the end of the maturity period.
    /// </summary>
    [IsoId("__pHrM65OEeuo-IflVgGqiA")]
    [DisplayName("End")]
    [IsoXmlTag("End")]
    public MaturityTerm2? End { get; init; }
}
