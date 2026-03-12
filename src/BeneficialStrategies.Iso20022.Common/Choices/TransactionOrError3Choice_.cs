// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the transaction details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionOrError3Choice.Transaction))]
    [KnownType(typeof(TransactionOrError3Choice.BusinessError))]
    [JsonDerivedType(typeof(TransactionOrError3Choice.Transaction),nameof(TransactionOrError3Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError3Choice.BusinessError),nameof(TransactionOrError3Choice.BusinessError))]
    [IsoId("_NI2W15lPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Or Error 3 Choice")]
    public abstract partial record TransactionOrError3Choice_
    {
    }
}
