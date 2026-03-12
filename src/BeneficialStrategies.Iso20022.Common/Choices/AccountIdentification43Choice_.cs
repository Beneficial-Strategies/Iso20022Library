// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification43Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification43Choice.AccountsList))]
    [JsonDerivedType(typeof(AccountIdentification43Choice.ForAllAccounts),nameof(AccountIdentification43Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification43Choice.AccountsList),nameof(AccountIdentification43Choice.AccountsList))]
    [IsoId("__2YHD_fDEeiNZp_PtLohLw")]
    [DisplayName("Account Identification 43 Choice")]
    public abstract partial record AccountIdentification43Choice_
    {
    }
}
