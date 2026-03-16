// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification78Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification78Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification78Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification78Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification78Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification78Choice.ForAllAccounts),nameof(AccountIdentification78Choice.ForAllAccounts))]
    [IsoId("_nLX7AZt3Ee-wQIOX0djF2w")]
    [DisplayName("Account Identification78Choice")]
    public abstract partial record AccountIdentification78Choice_
    {
    }
}
