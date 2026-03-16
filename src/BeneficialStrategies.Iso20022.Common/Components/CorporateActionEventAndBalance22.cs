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
[IsoId("_IThqTxn1EeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Event And Balance")]
public record CorporateActionEventAndBalance22
{
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_Io1y4xn1EeyroI8qKgB7Mg")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation15 GeneralInformation { get; init; }

    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_Io1y5Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification19 UnderlyingSecurity { get; init; }

    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_Io1y7Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance46? Balance { get; init; }

    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_Io1y9Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
