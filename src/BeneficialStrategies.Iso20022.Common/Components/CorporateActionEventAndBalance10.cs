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
[IsoId("_cfq2c5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Event And Balance")]
public record CorporateActionEventAndBalance10
{
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_cfq2dZKQEeWHWpTQn1FFVg")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation8 GeneralInformation { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_cfq2d5KQEeWHWpTQn1FFVg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification20 UnderlyingSecurity { get; init; }

    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_cfrcxZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails33? Balance { get; init; }

    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_cfrczZKQEeWHWpTQn1FFVg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
