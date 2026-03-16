// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType11Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType11Choice.Code),
        nameof(SecuritiesTransactionType11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType11Choice.Proprietary),
        nameof(SecuritiesTransactionType11Choice.Proprietary)
    )]
    [IsoId("_fw8YG_vmEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 11 Choice")]
    public abstract record SecuritiesTransactionType11Choice_ { }
}
