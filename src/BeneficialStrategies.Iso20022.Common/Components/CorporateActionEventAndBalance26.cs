// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Event And Balance26.
/// </summary>
[IsoId("_kNSucYVQEe-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Event And Balance26")]
public record CorporateActionEventAndBalance26
{
    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance50? Balance { get; init; }

    /// <summary>
    /// General Information.
    /// </summary>
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation17 GeneralInformation { get; init; }

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
