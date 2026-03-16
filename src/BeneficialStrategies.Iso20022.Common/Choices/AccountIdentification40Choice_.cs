// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification40Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification40Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification40Choice.ForAllAccounts),
        nameof(AccountIdentification40Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification40Choice.AccountsList),
        nameof(AccountIdentification40Choice.AccountsList)
    )]
    [IsoId("_ZijMJbXDEeiTob_PrFFUxA")]
    [DisplayName("Account Identification 40 Choice")]
    public abstract record AccountIdentification40Choice_ { }
}
