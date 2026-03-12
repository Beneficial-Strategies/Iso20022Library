// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between channel mode and terminal identification.
    /// </summary>
    [KnownType(typeof(CommunicationChannel1Choice.ChannelMode))]
    [KnownType(typeof(CommunicationChannel1Choice.TerminalIdentification))]
    [JsonDerivedType(typeof(CommunicationChannel1Choice.ChannelMode),nameof(CommunicationChannel1Choice.ChannelMode))]
    [JsonDerivedType(typeof(CommunicationChannel1Choice.TerminalIdentification),nameof(CommunicationChannel1Choice.TerminalIdentification))]
    [IsoId("_MfH4EA1DEeazkbJaoKTIIw")]
    [DisplayName("Communication Channel 1 Choice")]
    public abstract partial record CommunicationChannel1Choice_
    {
    }
}
