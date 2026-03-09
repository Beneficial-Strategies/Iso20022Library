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
    [KnownType(typeof(RejectionStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus13Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus13Choice.NoSpecifiedReason),nameof(RejectionStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus13Choice.Reason),nameof(RejectionStatus13Choice.Reason))]
    #endif
    [IsoId("_-ojZ8SwtEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus13Choice_
    #else
    public abstract partial class RejectionStatus13Choice_
    #endif
    {
    }
}
