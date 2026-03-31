// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a master agreement.
/// </summary>
[IsoId("_X7TZMcIrEeirIahpoG2ifA")]
[DisplayName("Master Agreement")]
public record MasterAgreement5
{
    /// <summary>
    /// Reference to any master agreement, if existent (such as ISDA Master Agreement; Master Power Purchase and Sale Agreement; International ForEx Master Agreement; European Master Agreement or any local Master Agreements).
    /// </summary>
    [IsoId("_YHuEk8IrEeirIahpoG2ifA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? Type { get; init; }

    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade, if applicable (such as 1992, 2002, etc).
    /// </summary>
    [IsoId("_YHuElcIrEeirIahpoG2ifA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? Version { get; init; }
}
