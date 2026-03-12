// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction2Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction2Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction2Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.Initiation),nameof(UnderlyingTransaction2Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.Interbank),nameof(UnderlyingTransaction2Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction2Choice.StatementEntry),nameof(UnderlyingTransaction2Choice.StatementEntry))]
    [IsoId("_P3N9Vp9XEeGBX4a4yy-WHg_2030305441")]
    [DisplayName("Underlying Transaction 2 Choice")]
    public abstract partial record UnderlyingTransaction2Choice_
    {
    }
}
