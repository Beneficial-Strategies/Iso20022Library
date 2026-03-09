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
    /// Type of the event.
    /// </summary>
    [KnownType(typeof(EventType1Choice.Code))]
    [KnownType(typeof(EventType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventType1Choice.Code),nameof(EventType1Choice.Code))]
    [JsonDerivedType(typeof(EventType1Choice.Proprietary),nameof(EventType1Choice.Proprietary))]
    #endif
    [IsoId("_71C2RqMgEeCJ6YNENx4h-w_337125079")]
    [DisplayName("Event Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventType1Choice_
    #else
    public abstract partial class EventType1Choice_
    #endif
    {
    }
}
