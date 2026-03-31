// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option Multiple Barrier Levels1.
/// </summary>
[IsoId("_ttTVodyaEe6BHYBNhkieQQ")]
[DisplayName("Option Multiple Barrier Levels1")]
public record OptionMultipleBarrierLevels1
{
    /// <summary>
    /// Lower Level.
    /// </summary>
    [DisplayName("Lower Level")]
    [IsoXmlTag("LwrLvl")]
    public required SecuritiesTransactionPrice23Choice_ LowerLevel { get; init; }

    /// <summary>
    /// Upper Level.
    /// </summary>
    [DisplayName("Upper Level")]
    [IsoXmlTag("UpperLvl")]
    public required SecuritiesTransactionPrice23Choice_ UpperLevel { get; init; }
}
