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
    [KnownType(typeof(RejectionStatus40Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus40Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus40Choice.NoSpecifiedReason),nameof(RejectionStatus40Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus40Choice.Reason),nameof(RejectionStatus40Choice.Reason))]
    #endif
    [IsoId("_ddA4kTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 40 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus40Choice_
    #else
    public abstract partial class RejectionStatus40Choice_
    #endif
    {
    }
}
