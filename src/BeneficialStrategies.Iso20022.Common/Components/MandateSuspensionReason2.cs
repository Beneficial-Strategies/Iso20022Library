// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the suspension reason.
/// </summary>
[IsoId("_Sk3nS249EeiU9cctagi5ow")]
[DisplayName("Mandate Suspension Reason")]
public record MandateSuspensionReason2
{
    /// <summary>
    /// Party that issues the suspension request.
    /// </summary>
    [IsoId("_SvTVoW49EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the suspension request.
    /// </summary>
    [IsoId("_SvTVo249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateSuspensionReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the suspension request reason.
    /// </summary>
    [IsoId("_SvTVpW49EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
