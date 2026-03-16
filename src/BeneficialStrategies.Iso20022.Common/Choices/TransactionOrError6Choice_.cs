// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Or Error6Choice.
    /// </summary>
    [KnownType(typeof(TransactionOrError6Choice.BusinessError))]
    [KnownType(typeof(TransactionOrError6Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError6Choice.BusinessError),nameof(TransactionOrError6Choice.BusinessError))]
    [JsonDerivedType(typeof(TransactionOrError6Choice.Transaction),nameof(TransactionOrError6Choice.Transaction))]
    [IsoId("_1yuesTEyEe6g-ffJsqGiSA")]
    [DisplayName("Transaction Or Error6Choice")]
    public abstract partial record TransactionOrError6Choice_
    {
    }
}
