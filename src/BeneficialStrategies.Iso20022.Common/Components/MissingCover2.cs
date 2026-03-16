// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide additional cover details for the claim non receipt.
/// </summary>
[IsoId("_T9zQW9p-Ed-ak6NoX_4Aeg_-1690835638")]
[DisplayName("Missing Cover")]
public record MissingCover2
{
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_T9zQXNp-Ed-ak6NoX_4Aeg_-1690835576")]
    [DisplayName("Missing Cover Indicator")]
    [IsoXmlTag("MssngCoverInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; }

    /// <summary>
    /// Set of elements provided to update incorrect settlement information for the cover related to the received payment instruction.
    /// </summary>
    [IsoId("_T99BUNp-Ed-ak6NoX_4Aeg_-1317732569")]
    [DisplayName("Cover Correction")]
    [IsoXmlTag("CoverCrrctn")]
    public SettlementInformation15? CoverCorrection { get; init; }
}
