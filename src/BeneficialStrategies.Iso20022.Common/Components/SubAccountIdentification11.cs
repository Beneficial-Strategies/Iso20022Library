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
[IsoId("_T_SeFNp-Ed-ak6NoX_4Aeg_-1778750165")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification11
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_T_SeFdp-Ed-ak6NoX_4Aeg_-1778750087")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_T_SeFtp-Ed-ak6NoX_4Aeg_-1778750044")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount14 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_T_SeF9p-Ed-ak6NoX_4Aeg_-1778750139")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities subaccount.
    /// </summary>
    [IsoId("_T_SeGNp-Ed-ak6NoX_4Aeg_-1778750122")]
    [DisplayName("Balance For Sub Account")]
    [IsoXmlTag("BalForSubAcct")]
    public ValueList<AggregateBalanceInformation9> BalanceForSubAccount { get; init; } = [];
}
