// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the ordering in which the resulting transaction reports should be returned.
/// </summary>
[IsoId("_s9PP4N6QEeiwsev40qZGEQ")]
[DisplayName("Search Output Order")]
public record SearchOutputOrder1
{
    /// <summary>
    /// Ordering criteria for the transaction report.
    /// </summary>
    [IsoId("_0aWhsN6QEeiwsev40qZGEQ")]
    [DisplayName("Criteria Order")]
    [IsoXmlTag("CritOrdr")]
    public ValueList<CriteriaOrder1> CriteriaOrder { get; init; } = [];
    // ID for the above is _0aWhsN6QEeiwsev40qZGEQ
}
