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
[IsoId("_fytnkH5gEea7cqFPsAF3tQ")]
[DisplayName("Mandate Copy")]
public record MandateCopy1
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_P7yVsH5hEea7cqFPsAF3tQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_v8iK0H5gEea7cqFPsAF3tQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Indicates the status of the mandate.
    /// </summary>
    [IsoId("_XY87UJm_Eeao_Z127E9uYg")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IoCecH5lEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
