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
    [KnownType(typeof(RejectionStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus20Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus20Choice.NoSpecifiedReason),nameof(RejectionStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus20Choice.Reason),nameof(RejectionStatus20Choice.Reason))]
    #endif
    [IsoId("_mdrUlzzpEeWeNtT0s2RbkQ")]
    [DisplayName("Rejection Status 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus20Choice_
    #else
    public abstract partial class RejectionStatus20Choice_
    #endif
    {
    }
}
