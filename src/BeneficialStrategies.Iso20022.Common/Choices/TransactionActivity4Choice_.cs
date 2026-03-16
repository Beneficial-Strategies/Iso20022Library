// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the transaction activity identification.
    /// </summary>
    [KnownType(typeof(TransactionActivity4Choice.Code))]
    [KnownType(typeof(TransactionActivity4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionActivity4Choice.Code),
        nameof(TransactionActivity4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TransactionActivity4Choice.Proprietary),
        nameof(TransactionActivity4Choice.Proprietary)
    )]
    [IsoId("_8VKXSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Activity 4 Choice")]
    public abstract record TransactionActivity4Choice_ { }
}
