// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification52Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification52Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(
        typeof(AccountIdentification52Choice.ForAllAccounts),
        nameof(AccountIdentification52Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification52Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification52Choice.AccountsListAndBalanceDetails)
    )]
    [IsoId("_ps_Rqzi7Eeydid5dcNPKvg")]
    [DisplayName("Account Identification 52 Choice")]
    public abstract record AccountIdentification52Choice_ { }
}
