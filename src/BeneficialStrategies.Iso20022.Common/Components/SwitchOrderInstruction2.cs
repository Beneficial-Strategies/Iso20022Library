// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a switch order.
/// </summary>
[IsoId("_RNhhFtp-Ed-ak6NoX_4Aeg_-925024145")]
[DisplayName("Switch Order Instruction")]
public record SwitchOrderInstruction2
{
    /// <summary>
    /// Information related to the switch order.
    /// </summary>
    [IsoId("_RNhhF9p-Ed-ak6NoX_4Aeg_-925023776")]
    [DisplayName("Switch Order Details")]
    [IsoXmlTag("SwtchOrdrDtls")]
    public ValueList<SwitchOrder3> SwitchOrderDetails { get; init; } = [];

    // ID for the above is _RNhhF9p-Ed-ak6NoX_4Aeg_-925023776

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RNhhGNp-Ed-ak6NoX_4Aeg_-925024109")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
