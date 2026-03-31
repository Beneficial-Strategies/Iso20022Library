// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unless bilaterally agreed between the Sender and the Receiver, additional information must not contain information that can be provided in a structured field.
/// </summary>
[IsoId("_2xhasLzhEeivTd4NUfCi2g")]
[DisplayName("Additional Information")]
public record AdditionalInformation24
{
    /// <summary>
    /// Provides additional information on the collateral instruction.
    /// </summary>
    [IsoId("_M3nIELziEeivTd4NUfCi2g")]
    [DisplayName("Collateral Instruction")]
    [IsoXmlTag("CollInstr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? CollateralInstruction { get; init; }

    /// <summary>
    /// Narrative information visible to other parties.
    /// </summary>
    [IsoId("_dOOxMLziEeivTd4NUfCi2g")]
    [DisplayName("Note")]
    [IsoXmlTag("Note")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Note { get; init; }
}
