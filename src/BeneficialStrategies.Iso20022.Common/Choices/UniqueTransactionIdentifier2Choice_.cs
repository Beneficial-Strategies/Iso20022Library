// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueTransactionIdentifier2Choice.UniqueTransactionIdentifier))]
    [KnownType(typeof(UniqueTransactionIdentifier2Choice.Proprietary))]
    [JsonDerivedType(typeof(UniqueTransactionIdentifier2Choice.UniqueTransactionIdentifier),nameof(UniqueTransactionIdentifier2Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(typeof(UniqueTransactionIdentifier2Choice.Proprietary),nameof(UniqueTransactionIdentifier2Choice.Proprietary))]
    [IsoId("_ctnq8SyFEe2xAdY9t5fB3g")]
    [DisplayName("Unique Transaction Identifier 2 Choice")]
    public abstract partial record UniqueTransactionIdentifier2Choice_
    {
    }
}
