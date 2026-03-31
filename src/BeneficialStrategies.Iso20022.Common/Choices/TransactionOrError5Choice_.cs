// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the transaction details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionOrError5Choice.Transaction))]
    [KnownType(typeof(TransactionOrError5Choice.BusinessError))]
    [JsonDerivedType(
        typeof(TransactionOrError5Choice.Transaction),
        nameof(TransactionOrError5Choice.Transaction)
    )]
    [JsonDerivedType(
        typeof(TransactionOrError5Choice.BusinessError),
        nameof(TransactionOrError5Choice.BusinessError)
    )]
    [IsoId("_dmIBNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Or Error 5 Choice")]
    public abstract record TransactionOrError5Choice_ { }
}
