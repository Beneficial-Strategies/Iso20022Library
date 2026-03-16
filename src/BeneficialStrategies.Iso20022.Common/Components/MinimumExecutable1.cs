// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Minimum Executable1.
/// </summary>
[IsoId("_WeU5IGvpEe2Re-GccwOX8g")]
[DisplayName("Minimum Executable1")]
public record MinimumExecutable1
{
    /// <summary>
    /// First Execution Only.
    /// </summary>
    [DisplayName("First Execution Only")]
    [IsoXmlTag("FrstExctnOnly")]
    public IsoTrueFalseIndicator? FirstExecutionOnly { get; init; }

    /// <summary>
    /// Size.
    /// </summary>
    [DisplayName("Size")]
    [IsoXmlTag("Sz")]
    public FinancialInstrumentQuantity25Choice_? Size { get; init; }
}
