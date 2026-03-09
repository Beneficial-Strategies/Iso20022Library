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
    [KnownType(typeof(PendingStatus68Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus68Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus68Choice.NoSpecifiedReason),nameof(PendingStatus68Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus68Choice.Reason),nameof(PendingStatus68Choice.Reason))]
    #endif
    [IsoId("_piJUEzi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Status 68 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus68Choice_
    #else
    public abstract partial class PendingStatus68Choice_
    #endif
    {
    }
}
