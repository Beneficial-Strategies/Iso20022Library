// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrOperationalError3Choice.AccountReport))]
    [KnownType(typeof(AccountOrOperationalError3Choice.OperationalError))]
    [JsonDerivedType(typeof(AccountOrOperationalError3Choice.AccountReport),nameof(AccountOrOperationalError3Choice.AccountReport))]
    [JsonDerivedType(typeof(AccountOrOperationalError3Choice.OperationalError),nameof(AccountOrOperationalError3Choice.OperationalError))]
    [IsoId("_fGTIoZ-WEee28J7y9KlTWg")]
    [DisplayName("Account Or Operational Error 3 Choice")]
    public abstract partial record AccountOrOperationalError3Choice_
    {
    }
}
