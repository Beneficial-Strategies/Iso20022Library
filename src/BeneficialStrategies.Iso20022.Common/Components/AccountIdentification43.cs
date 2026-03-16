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
[IsoId("_SQJWEZcFEee8S7xwGG7Veg")]
[DisplayName("Account Identification")]
public record AccountIdentification43
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_SfUahZcFEee8S7xwGG7Veg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_SfUajZcFEee8S7xwGG7Veg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification92Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_SfUalZcFEee8S7xwGG7Veg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [IsoId("_SfUanZcFEee8S7xwGG7Veg")]
    [DisplayName("Corporate Action Event And Balance")]
    [IsoXmlTag("CorpActnEvtAndBal")]
    public ValueList<CorporateActionEventAndBalance13> CorporateActionEventAndBalance { get; init; } =
        [];
}
