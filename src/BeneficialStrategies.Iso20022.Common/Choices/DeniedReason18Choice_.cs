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
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason18Choice.Code))]
    [KnownType(typeof(DeniedReason18Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeniedReason18Choice.Code),nameof(DeniedReason18Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason18Choice.Proprietary),nameof(DeniedReason18Choice.Proprietary))]
    #endif
    [IsoId("_6BLiL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Reason 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeniedReason18Choice_
    #else
    public abstract partial class DeniedReason18Choice_
    #endif
    {
    }
}
