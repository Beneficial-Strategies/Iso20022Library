// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
[IsoId("_doLKH5wuEeazcsnODTksnQ")]
[DisplayName("Account Identification")]
public record AccountIdentification41
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_doLKI5wuEeazcsnODTksnQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_doLKK5wuEeazcsnODTksnQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification103Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_doLKM5wuEeazcsnODTksnQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [IsoId("_doLKO5wuEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event And Balance")]
    [IsoXmlTag("CorpActnEvtAndBal")]
    public ValueList<CorporateActionEventAndBalance12> CorporateActionEventAndBalance { get; init; } =
        [];
}
