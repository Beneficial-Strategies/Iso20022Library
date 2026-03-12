// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification53Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification53Choice.AccountsListAndBalanceDetails))]
    [JsonDerivedType(typeof(AccountIdentification53Choice.ForAllAccounts),nameof(AccountIdentification53Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification53Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification53Choice.AccountsListAndBalanceDetails))]
    [IsoId("_p3aY0zi7Eeydid5dcNPKvg")]
    [DisplayName("Account Identification 53 Choice")]
    public abstract partial record AccountIdentification53Choice_
    {
    }
}
