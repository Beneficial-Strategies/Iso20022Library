// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType46Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType46Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType46Choice.Code),
        nameof(SecuritiesTransactionType46Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType46Choice.Proprietary),
        nameof(SecuritiesTransactionType46Choice.Proprietary)
    )]
    [IsoId("_GajacdYPEeiHVOfMzoKxnA")]
    [DisplayName("Securities Transaction Type 46 Choice")]
    public abstract record SecuritiesTransactionType46Choice_ { }
}
