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
    [KnownType(typeof(CancelledStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus16Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledStatus16Choice.NoSpecifiedReason),nameof(CancelledStatus16Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus16Choice.Reason),nameof(CancelledStatus16Choice.Reason))]
    #endif
    [IsoId("_6HWbW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled Status 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatus16Choice_
    #else
    public abstract partial class CancelledStatus16Choice_
    #endif
    {
    }
}
