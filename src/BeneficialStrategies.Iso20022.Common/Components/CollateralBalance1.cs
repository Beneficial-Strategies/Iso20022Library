// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral held by party A and/or B.
/// </summary>
[IsoId("_UmfA9tp-Ed-ak6NoX_4Aeg_1045581242")]
[DisplayName("Collateral Balance")]
public record CollateralBalance1
{
    /// <summary>
    /// Collateral currently held by party A.
    /// </summary>
    [IsoId("_UmfA99p-Ed-ak6NoX_4Aeg_-266938996")]
    [DisplayName("Held By Party A")]
    [IsoXmlTag("HeldByPtyA")]
    public required ActiveCurrencyAndAmount HeldByPartyA { get; init; }

    /// <summary>
    /// Collateral currently held by party B.
    /// </summary>
    [IsoId("_UmfA-Np-Ed-ak6NoX_4Aeg_-332033306")]
    [DisplayName("Held By Party B")]
    [IsoXmlTag("HeldByPtyB")]
    public required ActiveCurrencyAndAmount HeldByPartyB { get; init; }
}
