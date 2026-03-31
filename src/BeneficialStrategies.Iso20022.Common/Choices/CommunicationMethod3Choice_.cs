// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the method of transmission.
    /// </summary>
    [KnownType(typeof(CommunicationMethod3Choice.Code))]
    [KnownType(typeof(CommunicationMethod3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CommunicationMethod3Choice.Code),
        nameof(CommunicationMethod3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CommunicationMethod3Choice.Proprietary),
        nameof(CommunicationMethod3Choice.Proprietary)
    )]
    [IsoId("_WBqvcQgqEeSUG-8hqXsVMQ")]
    [DisplayName("Communication Method 3 Choice")]
    public abstract record CommunicationMethod3Choice_ { }
}
