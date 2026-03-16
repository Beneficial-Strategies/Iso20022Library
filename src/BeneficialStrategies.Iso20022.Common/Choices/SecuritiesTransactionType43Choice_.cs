// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType43Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType43Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType43Choice.Code),
        nameof(SecuritiesTransactionType43Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType43Choice.Proprietary),
        nameof(SecuritiesTransactionType43Choice.Proprietary)
    )]
    [IsoId("_dc-V8dEfEeiO-eodGv5iKQ")]
    [DisplayName("Securities Transaction Type 43 Choice")]
    public abstract record SecuritiesTransactionType43Choice_ { }
}
