// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the transaction activity identification.
    /// </summary>
    [KnownType(typeof(TransactionActivity3Choice.Code))]
    [KnownType(typeof(TransactionActivity3Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionActivity3Choice.Code),nameof(TransactionActivity3Choice.Code))]
    [JsonDerivedType(typeof(TransactionActivity3Choice.Proprietary),nameof(TransactionActivity3Choice.Proprietary))]
    [IsoId("_iF2-wTqDEeWVrPy0StzzSg")]
    [DisplayName("Transaction Activity 3 Choice")]
    public abstract partial record TransactionActivity3Choice_
    {
    }
}
