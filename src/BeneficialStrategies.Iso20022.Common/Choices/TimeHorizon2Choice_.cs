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
    /// Choice of formats for a time horizon.
    /// </summary>
    [KnownType(typeof(TimeHorizon2Choice.NumberOfYears))]
    [KnownType(typeof(TimeHorizon2Choice.TimeFrame))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeHorizon2Choice.NumberOfYears),nameof(TimeHorizon2Choice.NumberOfYears))]
    [JsonDerivedType(typeof(TimeHorizon2Choice.TimeFrame),nameof(TimeHorizon2Choice.TimeFrame))]
    #endif
    [IsoId("_U38AEbVOEeqkjqDuFVh1-A")]
    [DisplayName("Time Horizon 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeHorizon2Choice_
    #else
    public abstract partial class TimeHorizon2Choice_
    #endif
    {
    }
}
