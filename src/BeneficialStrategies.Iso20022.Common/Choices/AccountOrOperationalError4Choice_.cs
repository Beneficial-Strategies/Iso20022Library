// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrOperationalError4Choice.AccountReport))]
    [KnownType(typeof(AccountOrOperationalError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(AccountOrOperationalError4Choice.AccountReport),
        nameof(AccountOrOperationalError4Choice.AccountReport)
    )]
    [JsonDerivedType(
        typeof(AccountOrOperationalError4Choice.OperationalError),
        nameof(AccountOrOperationalError4Choice.OperationalError)
    )]
    [IsoId("_MZGBgW49EeiU9cctagi5ow")]
    [DisplayName("Account Or Operational Error 4 Choice")]
    public abstract record AccountOrOperationalError4Choice_ { }
}
