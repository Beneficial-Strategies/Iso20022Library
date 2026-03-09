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
    [KnownType(typeof(RejectionStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus44Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus44Choice.NoSpecifiedReason),nameof(RejectionStatus44Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus44Choice.Reason),nameof(RejectionStatus44Choice.Reason))]
    #endif
    [IsoId("_f9795zi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus44Choice_
    #else
    public abstract partial class RejectionStatus44Choice_
    #endif
    {
    }
}
