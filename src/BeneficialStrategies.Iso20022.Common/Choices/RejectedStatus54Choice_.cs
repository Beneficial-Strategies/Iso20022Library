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
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus54Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus54Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus54Choice.NoSpecifiedReason),nameof(RejectedStatus54Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus54Choice.Reason),nameof(RejectedStatus54Choice.Reason))]
    #endif
    [IsoId("_NpuWOF99Ee262vCSVgjImg")]
    [DisplayName("Rejected Status 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus54Choice_
    #else
    public abstract partial class RejectedStatus54Choice_
    #endif
    {
    }
}
