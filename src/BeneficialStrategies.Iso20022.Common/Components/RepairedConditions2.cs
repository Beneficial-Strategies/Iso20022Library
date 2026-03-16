// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charge or commission of the original individual order details that have been repaired so that the order can be accepted.
/// </summary>
[IsoId("_U3USS9p-Ed-ak6NoX_4Aeg_-1187208577")]
[DisplayName("Repaired Conditions")]
public record RepairedConditions2
{
    /// <summary>
    /// Charge from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_U3USTNp-Ed-ak6NoX_4Aeg_-1187208550")]
    [DisplayName("Repaired Charge")]
    [IsoXmlTag("RprdChrg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Charge11> RepairedCharge { get; init; } = [];

    /// <summary>
    /// Commission from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_U3eDQNp-Ed-ak6NoX_4Aeg_-1187208516")]
    [DisplayName("Repaired Commission")]
    [IsoXmlTag("RprdComssn")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Commission7> RepairedCommission { get; init; } = [];
}
