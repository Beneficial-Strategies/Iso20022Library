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
    /// Choice between a reason and no reason for the general meeting instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus55Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus55Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus55Choice.NoSpecifiedReason),nameof(PendingStatus55Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus55Choice.Reason),nameof(PendingStatus55Choice.Reason))]
    #endif
    [IsoId("_Tfp1KbKdEemux5trsZcCpw")]
    [DisplayName("Pending Status 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus55Choice_
    #else
    public abstract partial class PendingStatus55Choice_
    #endif
    {
    }
}
