// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification14Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification14Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification14Choice.ForAllAccounts),nameof(AccountIdentification14Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification14Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification14Choice.AccountsListAndBalanceDetails))]
    [IsoId("_qVQlKeaPEd-q8fx_Zl_34A")]
    [DisplayName("Account Identification 14 Choice")]
    public abstract partial record AccountIdentification14Choice_
    {
    }
}
