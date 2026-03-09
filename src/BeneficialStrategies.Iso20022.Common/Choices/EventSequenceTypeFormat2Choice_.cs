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
    [KnownType(typeof(EventSequenceTypeFormat2Choice.Code))]
    [KnownType(typeof(EventSequenceTypeFormat2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EventSequenceTypeFormat2Choice.Code),nameof(EventSequenceTypeFormat2Choice.Code))]
    [JsonDerivedType(typeof(EventSequenceTypeFormat2Choice.Proprietary),nameof(EventSequenceTypeFormat2Choice.Proprietary))]
    #endif
    [IsoId("_5yK74fyVEeiKOe8GCUL1Lg")]
    [DisplayName("Event Sequence Type Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventSequenceTypeFormat2Choice_
    #else
    public abstract partial class EventSequenceTypeFormat2Choice_
    #endif
    {
    }
}
