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
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus53Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus53Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus53Choice.NoSpecifiedReason),nameof(RejectedStatus53Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus53Choice.Reason),nameof(RejectedStatus53Choice.Reason))]
    #endif
    [IsoId("_oj4IyzQXEe2o-K1dwNg8Gg")]
    [DisplayName("Rejected Status 53 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus53Choice_
    #else
    public abstract partial class RejectedStatus53Choice_
    #endif
    {
    }
}
