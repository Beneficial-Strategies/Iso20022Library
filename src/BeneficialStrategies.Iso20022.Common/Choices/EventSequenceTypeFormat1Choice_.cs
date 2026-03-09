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
    /// Choice between a standard code and proprietary code to specify the type of event in a series of predefined or planned events.
    /// </summary>
    [KnownType(typeof(EventSequenceTypeFormat1Choice.Code))]
    [KnownType(typeof(EventSequenceTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventSequenceTypeFormat1Choice.Code),nameof(EventSequenceTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat1Choice.Proprietary),nameof(EventSequenceTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_jkicELXIEeiTob_PrFFUxA")]
    [DisplayName("Event Sequence Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventSequenceTypeFormat1Choice_
    #else
    public abstract partial class EventSequenceTypeFormat1Choice_
    #endif
    {
    }
}
