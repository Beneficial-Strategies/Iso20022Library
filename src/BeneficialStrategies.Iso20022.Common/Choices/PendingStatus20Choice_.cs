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
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(PendingStatus20Choice.Forwarded))]
    [KnownType(typeof(PendingStatus20Choice.UnderInvestigation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus20Choice.Forwarded),nameof(PendingStatus20Choice.Forwarded))]
    [JsonDerivedType(typeof(PendingStatus20Choice.UnderInvestigation),nameof(PendingStatus20Choice.UnderInvestigation))]
    #endif
    [IsoId("_0k3gwglIEeGATtfOBToyew_-1102038135")]
    [DisplayName("Pending Status 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus20Choice_
    #else
    public abstract partial class PendingStatus20Choice_
    #endif
    {
    }
}
