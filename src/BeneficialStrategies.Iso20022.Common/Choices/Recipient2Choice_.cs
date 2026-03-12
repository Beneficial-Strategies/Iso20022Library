// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient2Choice.KeyTransport))]
    [KnownType(typeof(Recipient2Choice.KEK))]
    [JsonDerivedType(typeof(Recipient2Choice.KeyTransport),nameof(Recipient2Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient2Choice.KEK),nameof(Recipient2Choice.KEK))]
    [IsoId("_EvioMQioEeKn9O5oyej_zw")]
    [DisplayName("Recipient 2 Choice")]
    public abstract partial record Recipient2Choice_
    {
    }
}
