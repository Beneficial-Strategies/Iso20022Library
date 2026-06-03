// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_zExwYag1EfCXwLUUylXgrQ")]
[DisplayName("Sub Account Identification75")]
public record SubAccountIdentification75
{
    [IsoId("_zHJH56g1EfCXwLUUylXgrQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification122Choice_? AccountOwner { get; init; }

    [IsoId("_zHJH6ag1EfCXwLUUylXgrQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    [IsoId("_zHJH8ag1EfCXwLUUylXgrQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    [IsoId("_zHJH-ag1EfCXwLUUylXgrQ")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation47> BalanceForSubAccount { get; init; } = [];
}
