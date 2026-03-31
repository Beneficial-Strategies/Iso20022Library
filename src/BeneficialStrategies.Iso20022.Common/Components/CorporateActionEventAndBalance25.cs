// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Event And Balance25.
/// </summary>
[IsoId("_UotqZXSdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Event And Balance25")]
public record CorporateActionEventAndBalance25
{
    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance49? Balance { get; init; }

    /// <summary>
    /// General Information.
    /// </summary>
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation16 GeneralInformation { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Underlying Security.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification20 UnderlyingSecurity { get; init; }
}
