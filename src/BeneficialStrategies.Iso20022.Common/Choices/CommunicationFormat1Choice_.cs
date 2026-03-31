// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a choice of format for statements.
    /// </summary>
    [KnownType(typeof(CommunicationFormat1Choice.Code))]
    [KnownType(typeof(CommunicationFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CommunicationFormat1Choice.Code),
        nameof(CommunicationFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CommunicationFormat1Choice.Proprietary),
        nameof(CommunicationFormat1Choice.Proprietary)
    )]
    [IsoId("_1gGtkA1dEeKGXqvMN6jpiw")]
    [DisplayName("Communication Format 1 Choice")]
    public abstract record CommunicationFormat1Choice_ { }
}
