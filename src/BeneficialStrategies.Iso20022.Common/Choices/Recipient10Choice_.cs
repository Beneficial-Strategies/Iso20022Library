// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient10Choice.KeyTransport))]
    [KnownType(typeof(Recipient10Choice.KEK))]
    [KnownType(typeof(Recipient10Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient10Choice.KeyTransport),nameof(Recipient10Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient10Choice.KEK),nameof(Recipient10Choice.KEK))]
    [JsonDerivedType(typeof(Recipient10Choice.KeyIdentifier),nameof(Recipient10Choice.KeyIdentifier))]
    [IsoId("_Wl_KAS8jEeu125Ip9zFcsQ")]
    [DisplayName("Recipient 10 Choice")]
    public abstract partial record Recipient10Choice_
    {
    }
}
