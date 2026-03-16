// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limits8.
/// </summary>
[IsoId("_5UkNxTEyEe6g-ffJsqGiSA")]
[DisplayName("Limits8")]
public partial record Limits8
{
    #nullable enable

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

    
    #nullable disable
    
}
