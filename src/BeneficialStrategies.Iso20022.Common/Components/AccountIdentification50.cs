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
[IsoId("_D3TIW_fQEeiNZp_PtLohLw")]
[DisplayName("Account Identification")]
public record AccountIdentification50
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_D3TIYffQEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_D3TIaffQEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_D3TIcffQEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [IsoId("_D3TIeffQEeiNZp_PtLohLw")]
    [DisplayName("Corporate Action Event And Balance")]
    [IsoXmlTag("CorpActnEvtAndBal")]
    public ValueList<CorporateActionEventAndBalance16> CorporateActionEventAndBalance { get; init; } =
        [];
}
