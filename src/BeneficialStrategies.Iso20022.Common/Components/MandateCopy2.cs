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
[IsoId("_RSUaQW49EeiU9cctagi5ow")]
[DisplayName("Mandate Copy")]
public record MandateCopy2
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Rb2wwW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_Rb2ww249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate6Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Indicates the status of the mandate.
    /// </summary>
    [IsoId("_Rb2wxW49EeiU9cctagi5ow")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Rb2wx249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
