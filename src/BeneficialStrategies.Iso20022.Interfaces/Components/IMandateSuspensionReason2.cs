// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the suspension reason.
/// </summary>
[IsoId("_Sk3nS249EeiU9cctagi5ow")]
public interface IMandateSuspensionReason2 : IIsoComponent
{
    /// <summary>
    /// Party that issues the suspension request.
    /// </summary>
    [IsoId("_SvTVoW49EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification135? Originator { get; }

    /// <summary>
    /// Specifies the reason for the suspension request.
    /// </summary>
    [IsoId("_SvTVo249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSuspensionReason1Choice Reason { get; }

    /// <summary>
    /// Further details on the suspension request reason.
    /// </summary>
    [IsoId("_SvTVpW49EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
