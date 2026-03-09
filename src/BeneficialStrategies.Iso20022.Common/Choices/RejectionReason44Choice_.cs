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
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason44Choice.Code))]
    [KnownType(typeof(RejectionReason44Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason44Choice.Code),nameof(RejectionReason44Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason44Choice.Proprietary),nameof(RejectionReason44Choice.Proprietary))]
    #endif
    [IsoId("_iB2NeStXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason44Choice_
    #else
    public abstract partial class RejectionReason44Choice_
    #endif
    {
    }
}
