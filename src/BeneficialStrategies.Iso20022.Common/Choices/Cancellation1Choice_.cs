// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation1Choice.Reference))]
    [KnownType(typeof(Cancellation1Choice.TransferOutDetails))]
    [JsonDerivedType(typeof(Cancellation1Choice.Reference), nameof(Cancellation1Choice.Reference))]
    [JsonDerivedType(
        typeof(Cancellation1Choice.TransferOutDetails),
        nameof(Cancellation1Choice.TransferOutDetails)
    )]
    [IsoId("_GYMTExg1EeK-_89we2b-bA")]
    [DisplayName("Cancellation 1 Choice")]
    public abstract record Cancellation1Choice_ { }
}
