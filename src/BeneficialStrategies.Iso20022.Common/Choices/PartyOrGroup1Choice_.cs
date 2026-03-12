// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a choice between one party or a group of parties.
    /// </summary>
    [KnownType(typeof(PartyOrGroup1Choice.GroupIdentification))]
    [KnownType(typeof(PartyOrGroup1Choice.Party))]
    [JsonDerivedType(typeof(PartyOrGroup1Choice.GroupIdentification),nameof(PartyOrGroup1Choice.GroupIdentification))]
    [JsonDerivedType(typeof(PartyOrGroup1Choice.Party),nameof(PartyOrGroup1Choice.Party))]
    [IsoId("_vpH0YA4TEeKGXqvMN6jpiw")]
    [DisplayName("Party Or Group 1 Choice")]
    public abstract partial record PartyOrGroup1Choice_
    {
    }
}
