// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType7Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType7Choice.Code),
        nameof(SecuritiesTransactionType7Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType7Choice.Proprietary),
        nameof(SecuritiesTransactionType7Choice.Proprietary)
    )]
    [IsoId("_xV3Vsd0fEd-Cb-IGbQ4hBQ")]
    [DisplayName("Securities Transaction Type 7 Choice")]
    public abstract record SecuritiesTransactionType7Choice_ { }
}
