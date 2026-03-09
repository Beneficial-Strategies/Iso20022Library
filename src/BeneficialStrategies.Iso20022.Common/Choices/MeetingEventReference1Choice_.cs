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
    /// Choice between a meeting event identification or a meeting event official identification.
    /// </summary>
    [KnownType(typeof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification))]
    [KnownType(typeof(MeetingEventReference1Choice.LinkedMeetingIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification),nameof(MeetingEventReference1Choice.LinkedIssuerMeetingIdentification))]
    [JsonDerivedType(typeof(MeetingEventReference1Choice.LinkedMeetingIdentification),nameof(MeetingEventReference1Choice.LinkedMeetingIdentification))]
    #endif
    [IsoId("__b3CGa7rEemG7MmivSuE5g")]
    [DisplayName("Meeting Event Reference 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MeetingEventReference1Choice_
    #else
    public abstract partial class MeetingEventReference1Choice_
    #endif
    {
    }
}
