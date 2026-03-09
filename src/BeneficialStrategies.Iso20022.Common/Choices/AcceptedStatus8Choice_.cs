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
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus8Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcceptedStatus8Choice.NoSpecifiedReason),nameof(AcceptedStatus8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus8Choice.Reason),nameof(AcceptedStatus8Choice.Reason))]
    #endif
    [IsoId("_4ZLV0UGUEeWqy4niLuXETA")]
    [DisplayName("Accepted Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedStatus8Choice_
    #else
    public abstract partial class AcceptedStatus8Choice_
    #endif
    {
    }
}
