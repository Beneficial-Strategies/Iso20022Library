// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Missing Cover6.
/// </summary>
[IsoId("_x9c2QTEyEe6g-ffJsqGiSA")]
[DisplayName("Missing Cover6")]
public record MissingCover6
{
    /// <summary>
    /// Cover Correction.
    /// </summary>
    [DisplayName("Cover Correction")]
    [IsoXmlTag("CoverCrrctn")]
    public SettlementInstruction16? CoverCorrection { get; init; }

    /// <summary>
    /// Missing Cover Indicator.
    /// </summary>
    [DisplayName("Missing Cover Indicator")]
    [IsoXmlTag("MssngCoverInd")]
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; }
}
