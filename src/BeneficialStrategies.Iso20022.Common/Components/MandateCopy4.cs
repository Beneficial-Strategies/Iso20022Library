// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Copy4.
/// </summary>
[IsoId("_5GXZsTEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Copy4")]
public record MandateCopy4
{
    /// <summary>
    /// Mandate Status.
    /// </summary>
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate10Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Original Message Information.
    /// </summary>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
