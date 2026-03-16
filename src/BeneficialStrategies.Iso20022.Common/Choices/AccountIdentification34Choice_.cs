// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification34Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification34Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification34Choice.ForAllAccounts),
        nameof(AccountIdentification34Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification34Choice.AccountsList),
        nameof(AccountIdentification34Choice.AccountsList)
    )]
    [IsoId("_cdRpC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Account Identification 34 Choice")]
    public abstract record AccountIdentification34Choice_ { }
}
