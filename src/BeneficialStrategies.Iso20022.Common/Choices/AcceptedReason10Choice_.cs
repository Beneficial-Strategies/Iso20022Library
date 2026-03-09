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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason10Choice.Code))]
    [KnownType(typeof(AcceptedReason10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcceptedReason10Choice.Code),nameof(AcceptedReason10Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason10Choice.Proprietary),nameof(AcceptedReason10Choice.Proprietary))]
    #endif
    [IsoId("_41TRM0GUEeWqy4niLuXETA")]
    [DisplayName("Accepted Reason 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedReason10Choice_
    #else
    public abstract partial class AcceptedReason10Choice_
    #endif
    {
    }
}
