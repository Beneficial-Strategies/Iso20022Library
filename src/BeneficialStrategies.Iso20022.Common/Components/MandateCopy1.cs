// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCopy1"/>
[IsoId("_fytnkH5gEea7cqFPsAF3tQ")]
[DisplayName("Mandate Copy")]
public partial record MandateCopy1
{
    /// <inheritdoc cref="IMandateCopy1.OriginalMessageInformation"/>
    [IsoId("_P7yVsH5hEea7cqFPsAF3tQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCopy1.OriginalMandate"/>
    [IsoId("_v8iK0H5gEea7cqFPsAF3tQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCopy1.MandateStatus"/>
    [IsoId("_XY87UJm_Eeao_Z127E9uYg")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    public MandateStatus1Choice_? MandateStatus { get; init; }

    /// <inheritdoc cref="IMandateCopy1.SupplementaryData"/>
    [IsoId("_IoCecH5lEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
