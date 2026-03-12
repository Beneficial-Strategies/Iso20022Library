// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrOperationalError5Choice.AccountReport))]
    [KnownType(typeof(AccountOrOperationalError5Choice.OperationalError))]
    [JsonDerivedType(typeof(AccountOrOperationalError5Choice.AccountReport),nameof(AccountOrOperationalError5Choice.AccountReport))]
    [JsonDerivedType(typeof(AccountOrOperationalError5Choice.OperationalError),nameof(AccountOrOperationalError5Choice.OperationalError))]
    [IsoId("_fAfGYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Operational Error 5 Choice")]
    public abstract partial record AccountOrOperationalError5Choice_
    {
    }
}
