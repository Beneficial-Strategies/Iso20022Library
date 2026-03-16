// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification6Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification6Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification6Choice.ForAllAccounts),
        nameof(AccountIdentification6Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification6Choice.AccountsList),
        nameof(AccountIdentification6Choice.AccountsList)
    )]
    [IsoId("_QSgqVdp-Ed-ak6NoX_4Aeg_-131069357")]
    [DisplayName("Account Identification 6 Choice")]
    public abstract record AccountIdentification6Choice_ { }
}
