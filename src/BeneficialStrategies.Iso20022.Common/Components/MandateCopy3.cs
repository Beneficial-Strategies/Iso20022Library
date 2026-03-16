// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, for which a copy of the details is requested.
/// </summary>
[IsoId("_fUKQUdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Copy")]
public record MandateCopy3
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_fVmawdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_fVmaw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate9Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Indicates the status of the mandate.
    /// </summary>
    [IsoId("_fVmaxdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fVmax9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
