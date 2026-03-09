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
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus32Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus32Choice.NoSpecifiedReason),nameof(PendingStatus32Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus32Choice.Reason),nameof(PendingStatus32Choice.Reason))]
    #endif
    [IsoId("_R-pFSydxEeOXAt_43VmZGw")]
    [DisplayName("Pending Status 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus32Choice_
    #else
    public abstract partial class PendingStatus32Choice_
    #endif
    {
    }
}
