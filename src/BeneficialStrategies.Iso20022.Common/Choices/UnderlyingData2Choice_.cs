// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying Data2Choice.
    /// </summary>
    [KnownType(typeof(UnderlyingData2Choice.Account))]
    [KnownType(typeof(UnderlyingData2Choice.Initiation))]
    [KnownType(typeof(UnderlyingData2Choice.Interbank))]
    [KnownType(typeof(UnderlyingData2Choice.Other))]
    [KnownType(typeof(UnderlyingData2Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingData2Choice.Account), nameof(UnderlyingData2Choice.Account))]
    [JsonDerivedType(
        typeof(UnderlyingData2Choice.Initiation),
        nameof(UnderlyingData2Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(UnderlyingData2Choice.Interbank),
        nameof(UnderlyingData2Choice.Interbank)
    )]
    [JsonDerivedType(typeof(UnderlyingData2Choice.Other), nameof(UnderlyingData2Choice.Other))]
    [JsonDerivedType(
        typeof(UnderlyingData2Choice.StatementEntry),
        nameof(UnderlyingData2Choice.StatementEntry)
    )]
    [IsoId("_Dl5lwRZ7Ee6d6Ip1Ob2kaQ")]
    [DisplayName("Underlying Data2Choice")]
    public abstract record UnderlyingData2Choice_ { }
}
