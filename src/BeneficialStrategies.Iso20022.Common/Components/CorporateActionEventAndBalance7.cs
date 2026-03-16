// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed account holdings information report for a corporate action event.
/// </summary>
[IsoId("_VBONEQ4xEeKVsZQr6J31Tg")]
[DisplayName("Corporate Action Event And Balance")]
public record CorporateActionEventAndBalance7
{
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_VYKtdQ4xEeKVsZQr6J31Tg")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation5 GeneralInformation { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_VYKteQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification14 UnderlyingSecurity { get; init; }

    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_VYKtgw4xEeKVsZQr6J31Tg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails9? Balance { get; init; }

    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_VYKtjQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
