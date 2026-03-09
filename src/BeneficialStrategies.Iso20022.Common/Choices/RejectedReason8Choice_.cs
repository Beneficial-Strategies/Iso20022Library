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
    /// Choice of formats for the reason of a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason8Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedReason8Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason8Choice.NoSpecifiedReason),nameof(RejectedReason8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedReason8Choice.Reason),nameof(RejectedReason8Choice.Reason))]
    #endif
    [IsoId("_tg-hCVj7EeOgwYxfAV02bg")]
    [DisplayName("Rejected Reason 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason8Choice_
    #else
    public abstract partial class RejectedReason8Choice_
    #endif
    {
    }
}
