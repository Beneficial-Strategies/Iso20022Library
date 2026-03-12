// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the transaction type.
    /// </summary>
    [KnownType(typeof(TransactionType2Choice.Type))]
    [KnownType(typeof(TransactionType2Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionType2Choice.Type),nameof(TransactionType2Choice.Type))]
    [JsonDerivedType(typeof(TransactionType2Choice.Proprietary),nameof(TransactionType2Choice.Proprietary))]
    [IsoId("_SyV7QQf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type 2 Choice")]
    public abstract partial record TransactionType2Choice_
    {
    }
}
