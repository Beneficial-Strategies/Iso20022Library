// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the derivative contract not included in the general financial instrument attributes component.
/// </summary>
[IsoId("_WfB289p-Ed-ak6NoX_4Aeg_2109906816")]
[DisplayName("Derivative Basic Attributes")]
public record DerivativeBasicAttributes2
{
    /// <summary>
    /// Amount underlying a financial derivatives contract necessary for calculating payments or receipts.
    /// </summary>
    [IsoId("_WfB29Np-Ed-ak6NoX_4Aeg_115762110")]
    [DisplayName("Notional Currency And Amount")]
    [IsoXmlTag("NtnlCcyAndAmt")]
    public required RestrictedFINActiveOrHistoricCurrencyAndAmount NotionalCurrencyAndAmount { get; init; }

    /// <summary>
    /// Indicates whether the given derivative price includes a prorated accrued interest component.
    /// </summary>
    [IsoId("_WfB29dp-Ed-ak6NoX_4Aeg_-1878382596")]
    [DisplayName("Interest Included In Price")]
    [IsoXmlTag("IntrstInclInPric")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestIncludedInPrice { get; init; }
}
