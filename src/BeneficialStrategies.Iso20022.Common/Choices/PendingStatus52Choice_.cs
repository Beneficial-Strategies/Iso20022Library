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
    [KnownType(typeof(PendingStatus52Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus52Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus52Choice.NoSpecifiedReason),nameof(PendingStatus52Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus52Choice.Reason),nameof(PendingStatus52Choice.Reason))]
    #endif
    [IsoId("_RvsMsYlsEeavwKddCbm3hg")]
    [DisplayName("Pending Status 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus52Choice_
    #else
    public abstract partial class PendingStatus52Choice_
    #endif
    {
    }
}
