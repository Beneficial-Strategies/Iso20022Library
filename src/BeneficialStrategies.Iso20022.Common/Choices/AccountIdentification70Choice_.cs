// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification70Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification70Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification70Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification70Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification70Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification70Choice.ForAllAccounts),nameof(AccountIdentification70Choice.ForAllAccounts))]
    [IsoId("_5QB9CY-9Ee-COKgew96POA")]
    [DisplayName("Account Identification70Choice")]
    public abstract partial record AccountIdentification70Choice_
    {
    }
}
