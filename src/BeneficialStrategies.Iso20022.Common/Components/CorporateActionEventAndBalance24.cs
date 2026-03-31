// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Event And Balance24.
/// </summary>
[IsoId("_WDtiUWHREe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Event And Balance24")]
public record CorporateActionEventAndBalance24
{
    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance48? Balance { get; init; }

    /// <summary>
    /// General Information.
    /// </summary>
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation15 GeneralInformation { get; init; }

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
    public required SecurityIdentification19 UnderlyingSecurity { get; init; }
}
