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
    [KnownType(typeof(RejectionStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus21Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus21Choice.NoSpecifiedReason),nameof(RejectionStatus21Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus21Choice.Reason),nameof(RejectionStatus21Choice.Reason))]
    #endif
    [IsoId("_cU5kYT0CEeWjqIDN7tjEjQ")]
    [DisplayName("Rejection Status 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus21Choice_
    #else
    public abstract partial class RejectionStatus21Choice_
    #endif
    {
    }
}
