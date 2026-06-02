// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the selected buyer protection instructions options.
/// </summary>
[IsoId("_qRwkwN_FEe-Ned3-G07x_A")]
[DisplayName("Corporate Action Option Statement1")]
public record CorporateActionOptionStatement1
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_-X82_N_FEe-Ned3-G07x_A")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_-X82_d_FEe-Ned3-G07x_A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption47Choice OptionType { get; init; }

    /// <summary>
    /// Buyer protection instruction information.
    /// </summary>
    [IsoId("_J7RJIN_GEe-Ned3-G07x_A")]
    [DisplayName("Buyer Protection Instruction Details")]
    [IsoXmlTag("BuyrPrtcnInstrDtls")]
    [MinLength(1)]
    public ValueList<BuyerProtectionInstructionDetails1> BuyerProtectionInstructionDetails { get; init; } = [];
}
