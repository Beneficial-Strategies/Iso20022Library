// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification50Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification50Choice.AccountsList))]
    [JsonDerivedType(
        typeof(AccountIdentification50Choice.ForAllAccounts),
        nameof(AccountIdentification50Choice.ForAllAccounts)
    )]
    [JsonDerivedType(
        typeof(AccountIdentification50Choice.AccountsList),
        nameof(AccountIdentification50Choice.AccountsList)
    )]
    [IsoId("_pdA8Hzi7Eeydid5dcNPKvg")]
    [DisplayName("Account Identification 50 Choice")]
    public abstract record AccountIdentification50Choice_ { }
}
