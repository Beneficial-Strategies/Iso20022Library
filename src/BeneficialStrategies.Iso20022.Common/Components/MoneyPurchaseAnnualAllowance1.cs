// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a Money Purchase Annual Allowance (MPAA).
/// </summary>
[IsoId("_YYAkcFK7EeiSDqv62fL07g")]
[DisplayName("Money Purchase Annual Allowance")]
public record MoneyPurchaseAnnualAllowance1
{
    /// <summary>
    /// Indicates whether the annual allowance has been triggered.
    /// </summary>
    [IsoId("_havwQFK7EeiSDqv62fL07g")]
    [DisplayName("Triggered")]
    [IsoXmlTag("Trggrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Triggered { get; init; }

    /// <summary>
    /// Date the annual allowance is taken.
    /// </summary>
    [IsoId("_kmRREFK7EeiSDqv62fL07g")]
    [DisplayName("Triggered Date")]
    [IsoXmlTag("TrggrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TriggeredDate { get; init; }
}
