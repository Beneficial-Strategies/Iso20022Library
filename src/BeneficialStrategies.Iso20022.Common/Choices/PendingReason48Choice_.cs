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
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason48Choice.Code))]
    [KnownType(typeof(PendingReason48Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason48Choice.Code),nameof(PendingReason48Choice.Code))]
    [JsonDerivedType(typeof(PendingReason48Choice.Proprietary),nameof(PendingReason48Choice.Proprietary))]
    #endif
    [IsoId("_SfAJ04lsEeavwKddCbm3hg")]
    [DisplayName("Pending Reason 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason48Choice_
    #else
    public abstract partial class PendingReason48Choice_
    #endif
    {
    }
}
