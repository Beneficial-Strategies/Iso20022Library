// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_AvzfAUGUEeWqy4niLuXETA")]
[DisplayName("Securities Option")]
public record SecuritiesOption52
{
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_A9VktUGUEeWqy4niLuXETA")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; }

    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_fHSboWOSEeW4z96Yfj3Wng")]
    [DisplayName("Instructed Quantity")]
    [IsoXmlTag("InstdQty")]
    public required Quantity20Choice_ InstructedQuantity { get; init; }
}
