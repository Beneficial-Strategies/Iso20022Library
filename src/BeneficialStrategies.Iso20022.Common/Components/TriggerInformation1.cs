// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element containing all information needed to identify who triggered the request.
/// </summary>
[IsoId("_52zPwNwoEeeKpa-yxjuKzQ")]
[DisplayName("Trigger Information")]
public record TriggerInformation1
{
    /// <summary>
    /// Actor who trigger the request.
    /// </summary>
    [IsoId("_LTOqYNwpEeeKpa-yxjuKzQ")]
    [DisplayName("Trigger Source")]
    [IsoXmlTag("TrggrSrc")]
    public required PartyType5Code TriggerSource { get; init; }

    /// <summary>
    /// Identification of the trigger source.
    /// </summary>
    [IsoId("_P5d1sNwpEeeKpa-yxjuKzQ")]
    [DisplayName("Source Identification")]
    [IsoXmlTag("SrcId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SourceIdentification { get; init; }

    /// <summary>
    /// Identification of the type of the call.
    /// </summary>
    [IsoId("_VQ0U4NwpEeeKpa-yxjuKzQ")]
    [DisplayName("Trigger Type")]
    [IsoXmlTag("TrggrTp")]
    public required ExchangePolicy1Code TriggerType { get; init; }

    /// <summary>
    /// Additional information related to request.
    /// </summary>
    [IsoId("_d7oI4NwpEeeKpa-yxjuKzQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalInformation { get; init; }
}
