// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Identification71Choice.
    /// </summary>
    [KnownType(typeof(AccountIdentification71Choice.AccountsListAndBalanceDetails))]
    [KnownType(typeof(AccountIdentification71Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification71Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification71Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification71Choice.ForAllAccounts),nameof(AccountIdentification71Choice.ForAllAccounts))]
    [IsoId("_5eB8i4-9Ee-COKgew96POA")]
    [DisplayName("Account Identification71Choice")]
    public abstract partial record AccountIdentification71Choice_
    {
    }
}
