// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the quantities (such as securities) in the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionQuantities2Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(TransactionQuantities2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionQuantities2Choice.Quantity),
        nameof(TransactionQuantities2Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount),
        nameof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities2Choice.Proprietary),
        nameof(TransactionQuantities2Choice.Proprietary)
    )]
    [IsoId("_tqJEMVkyEeGeoaLUQk__nA_658347651")]
    [DisplayName("Transaction Quantities 2 Choice")]
    public abstract record TransactionQuantities2Choice_ { }
}
