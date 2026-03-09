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
    /// Choice of rejection status.
    /// </summary>
    [KnownType(typeof(RejectionStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus27Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus27Choice.NoSpecifiedReason),nameof(RejectionStatus27Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus27Choice.Reason),nameof(RejectionStatus27Choice.Reason))]
    #endif
    [IsoId("_Vl2wcZNSEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus27Choice_
    #else
    public abstract partial class RejectionStatus27Choice_
    #endif
    {
    }
}
