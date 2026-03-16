// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on limits.
/// </summary>
[IsoId("_C3LJ5W4-EeiU9cctagi5ow")]
[DisplayName("Limits")]
public record Limits7
{
    /// <summary>
    /// Report is given for a current risk management type limit.
    /// </summary>
    [IsoId("_DAtgY24-EeiU9cctagi5ow")]
    [DisplayName("Current Limit")]
    [IsoXmlTag("CurLmt")]
    public LimitReport7? CurrentLimit { get; init; }

    /// <summary>
    /// Report is given for a default risk management type limit.
    /// </summary>
    [IsoId("_DAtgZW4-EeiU9cctagi5ow")]
    [DisplayName("Default Limit")]
    [IsoXmlTag("DfltLmt")]
    public LimitReport7? DefaultLimit { get; init; }
}
