// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification76Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification76Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification76Choice.ForAllAccounts))]
    [JsonDerivedType(
        typeof(AccountIdentification76Choice.AccountsListAndBalanceDetails),
        nameof(AccountIdentification76Choice.AccountsListAndBalanceDetails)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification76Choice.ForAllAccounts),
        nameof(AccountIdentification76Choice.ForAllAccounts)
    )]
    [IsoId("_l6N0lZt3Ee-wQIOX0djF2w")]
    [DisplayName("Account Identification76Choice")]
    public abstract record AccountIdentification76Choice_ { }
}
