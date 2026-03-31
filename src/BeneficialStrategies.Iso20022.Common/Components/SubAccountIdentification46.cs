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
[IsoId("_5enAiZNLEeWGlc8L7oPDIg")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification46
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_5enAkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification109? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_5enAmZNLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount34 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_5enAoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    [IsoId("_5enAqZNLEeWGlc8L7oPDIg")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation33> BalanceForSubAccount { get; init; } = [];
}
