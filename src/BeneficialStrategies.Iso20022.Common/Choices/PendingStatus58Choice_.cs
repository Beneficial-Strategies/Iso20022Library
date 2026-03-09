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
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus58Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus58Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus58Choice.NoSpecifiedReason),nameof(PendingStatus58Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus58Choice.Reason),nameof(PendingStatus58Choice.Reason))]
    #endif
    [IsoId("_sjdwQeaEEemtTOaHuc_63w")]
    [DisplayName("Pending Status 58 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus58Choice_
    #else
    public abstract partial class PendingStatus58Choice_
    #endif
    {
    }
}
