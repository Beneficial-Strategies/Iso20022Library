// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Decision of the voting party for one resolution.
/// </summary>
[IsoId("_CijmgV69EeSjaerr_EM7AQ")]
[DisplayName("Vote")]
public record Vote9
{
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_C_kSoV69EeSjaerr_EM7AQ")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Specifies the different instructions that can be used to vote.
    /// </summary>
    [IsoId("_C_kSo169EeSjaerr_EM7AQ")]
    [DisplayName("Vote Option")]
    [IsoXmlTag("VoteOptn")]
    public required VoteInstruction3Code VoteOption { get; init; }
}
