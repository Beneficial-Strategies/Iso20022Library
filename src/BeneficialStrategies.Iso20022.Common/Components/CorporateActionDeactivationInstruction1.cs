// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the deactivation.
/// </summary>
[IsoId("_UJuMddp-Ed-ak6NoX_4Aeg_-1685692105")]
[DisplayName("Corporate Action Deactivation Instruction")]
public record CorporateActionDeactivationInstruction1
{
    /// <summary>
    /// Date and time at which the CSD must deactivate the corporate action event or the option.
    /// </summary>
    [IsoId("_UJuMdtp-Ed-ak6NoX_4Aeg_1692268967")]
    [DisplayName("Deactivation Date And Time")]
    [IsoXmlTag("DeactvtnDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DeactivationDateAndTime { get; init; }

    /// <summary>
    /// Provides information about the option, when the deactivation instruction applies at the level of a corporate action option.
    /// </summary>
    [IsoId("_UJuMd9p-Ed-ak6NoX_4Aeg_972006480")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public CorporateActionOption2? OptionDetails { get; init; }
}
