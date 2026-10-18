// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCopy3"/>
[IsoId("_fUKQUdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Copy")]
public partial record MandateCopy3
{
    /// <inheritdoc cref="IMandateCopy3.OriginalMessageInformation"/>
    [IsoId("_fVmawdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCopy3.OriginalMandate"/>
    [IsoId("_fVmaw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate9Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCopy3.MandateStatus"/>
    [IsoId("_fVmaxdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <inheritdoc cref="IMandateCopy3.SupplementaryData"/>
    [IsoId("_fVmax9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
