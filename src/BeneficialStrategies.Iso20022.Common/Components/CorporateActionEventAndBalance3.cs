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
[IsoId("_-p04BeaUEd-q8fx_Zl_34A")]
[DisplayName("Corporate Action Event And Balance")]
public record CorporateActionEventAndBalance3
{
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_-p04B-aUEd-q8fx_Zl_34A")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation1 GeneralInformation { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_-p04CeaUEd-q8fx_Zl_34A")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required UnderlyingSecurity3 UnderlyingSecurity { get; init; }

    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_-p04C-aUEd-q8fx_Zl_34A")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails4? Balance { get; init; }

    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_-p04DeaUEd-q8fx_Zl_34A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
