// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional cover details for the claim non receipt.
/// </summary>
[IsoId("_dOHw4dcZEeqRFcf2R4bPBw")]
[DisplayName("Missing Cover")]
public record MissingCover5
{
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_dQdTMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Missing Cover Indicator")]
    [IsoXmlTag("MssngCoverInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; }

    /// <summary>
    /// Set of elements provided to update incorrect settlement information for the cover related to the received payment instruction.
    /// </summary>
    [IsoId("_dQdTM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Cover Correction")]
    [IsoXmlTag("CoverCrrctn")]
    public SettlementInstruction13? CoverCorrection { get; init; }
}
