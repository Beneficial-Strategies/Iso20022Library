// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limits8.
/// </summary>
[IsoId("_5UkNxTEyEe6g-ffJsqGiSA")]
[DisplayName("Limits8")]
public record Limits8
{
    /// <summary>
    /// Current Limit.
    /// </summary>
    [DisplayName("Current Limit")]
    [IsoXmlTag("CurLmt")]
    public ValueList<LimitReport8> CurrentLimit { get; init; } = [];

    /// <summary>
    /// Default Limit.
    /// </summary>
    [DisplayName("Default Limit")]
    [IsoXmlTag("DfltLmt")]
    public ValueList<LimitReport8> DefaultLimit { get; init; } = [];
}
