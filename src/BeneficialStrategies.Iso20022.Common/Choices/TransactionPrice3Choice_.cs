// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice3Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionPrice3Choice.DealPrice),
        nameof(TransactionPrice3Choice.DealPrice)
    )]
    [JsonDerivedType(
        typeof(TransactionPrice3Choice.Proprietary),
        nameof(TransactionPrice3Choice.Proprietary)
    )]
    [IsoId("_tp_6Q1kyEeGeoaLUQk__nA_-725028173")]
    [DisplayName("Transaction Price 3 Choice")]
    public abstract record TransactionPrice3Choice_ { }
}
