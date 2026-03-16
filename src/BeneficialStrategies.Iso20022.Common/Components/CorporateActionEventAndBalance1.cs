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
[IsoId("_QzTDMNp-Ed-ak6NoX_4Aeg_-397940404")]
[DisplayName("Corporate Action Event And Balance")]
public record CorporateActionEventAndBalance1
{
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_QzTDMdp-Ed-ak6NoX_4Aeg_1318887598")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation1 GeneralInformation { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_QzTDMtp-Ed-ak6NoX_4Aeg_847952146")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required UnderlyingSecurity1 UnderlyingSecurity { get; init; }

    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_QzTDM9p-Ed-ak6NoX_4Aeg_-715240098")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails4? Balance { get; init; }

    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_QzTDNNp-Ed-ak6NoX_4Aeg_496694477")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}
