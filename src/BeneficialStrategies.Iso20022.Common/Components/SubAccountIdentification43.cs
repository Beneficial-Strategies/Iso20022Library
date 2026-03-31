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
[IsoId("_Hh0LzR5dEeWE3PufGMdJ3w")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification43
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IBpiaR5dEeWE3PufGMdJ3w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_IBpicR5dEeWE3PufGMdJ3w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount25 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_IBpieR5dEeWE3PufGMdJ3w")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    [IsoId("_IBpigR5dEeWE3PufGMdJ3w")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation31> BalanceForSubAccount { get; init; } = [];
}
