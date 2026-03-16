// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Contains the data record in either Binary or text format.
    /// </summary>
    [KnownType(typeof(DataRecord1Choice.Binary))]
    [KnownType(typeof(DataRecord1Choice.Text))]
    [JsonDerivedType(typeof(DataRecord1Choice.Binary), nameof(DataRecord1Choice.Binary))]
    [JsonDerivedType(typeof(DataRecord1Choice.Text), nameof(DataRecord1Choice.Text))]
    [IsoId("_Gl7WgJb8Eeuc6pwKtqbEVQ")]
    [DisplayName("Data Record 1 Choice")]
    public abstract record DataRecord1Choice_ { }
}
