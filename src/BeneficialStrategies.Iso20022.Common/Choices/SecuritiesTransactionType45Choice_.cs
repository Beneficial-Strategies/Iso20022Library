// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType45Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType45Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType45Choice.Code),
        nameof(SecuritiesTransactionType45Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType45Choice.Proprietary),
        nameof(SecuritiesTransactionType45Choice.Proprietary)
    )]
    [IsoId("_m2WakdExEeiO-eodGv5iKQ")]
    [DisplayName("Securities Transaction Type 45 Choice")]
    public abstract record SecuritiesTransactionType45Choice_ { }
}
