// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient1Choice.KeyTransport))]
    [KnownType(typeof(Recipient1Choice.KEK))]
    [JsonDerivedType(typeof(Recipient1Choice.KeyTransport),nameof(Recipient1Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient1Choice.KEK),nameof(Recipient1Choice.KEK))]
    [IsoId("_SxIvuwEcEeCQm6a_G2yO_w_-1648646901")]
    [DisplayName("Recipient 1 Choice")]
    public abstract partial record Recipient1Choice_
    {
    }
}
