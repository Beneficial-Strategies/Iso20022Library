// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between channel mode and terminal identification.
    /// </summary>
    [KnownType(typeof(CommunicationChannel1Choice.ChannelMode))]
    [KnownType(typeof(CommunicationChannel1Choice.TerminalIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommunicationChannel1Choice.ChannelMode),nameof(CommunicationChannel1Choice.ChannelMode))]
    [JsonDerivedType(typeof(CommunicationChannel1Choice.TerminalIdentification),nameof(CommunicationChannel1Choice.TerminalIdentification))]
    #endif
    [IsoId("_MfH4EA1DEeazkbJaoKTIIw")]
    [DisplayName("Communication Channel 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommunicationChannel1Choice_
    #else
    public abstract partial class CommunicationChannel1Choice_
    #endif
    {
    }
}
