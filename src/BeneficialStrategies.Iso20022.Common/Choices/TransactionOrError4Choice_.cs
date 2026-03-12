// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the transaction details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionOrError4Choice.Transaction))]
    [KnownType(typeof(TransactionOrError4Choice.BusinessError))]
    [JsonDerivedType(typeof(TransactionOrError4Choice.Transaction),nameof(TransactionOrError4Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError4Choice.BusinessError),nameof(TransactionOrError4Choice.BusinessError))]
    [IsoId("_W6b5V249EeiU9cctagi5ow")]
    [DisplayName("Transaction Or Error 4 Choice")]
    public abstract partial record TransactionOrError4Choice_
    {
    }
}
