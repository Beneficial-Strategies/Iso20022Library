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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus69Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus69Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus69Choice.NoSpecifiedReason),nameof(PendingStatus69Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus69Choice.Reason),nameof(PendingStatus69Choice.Reason))]
    #endif
    [IsoId("_f99MEzi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Status 69 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus69Choice_
    #else
    public abstract partial class PendingStatus69Choice_
    #endif
    {
    }
}
