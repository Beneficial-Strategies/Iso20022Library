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
    [KnownType(typeof(RejectionOrRepairStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus34Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionOrRepairStatus34Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus34Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus34Choice.Reason),nameof(RejectionOrRepairStatus34Choice.Reason))]
    #endif
    [IsoId("_6GW9sZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Or Repair Status 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionOrRepairStatus34Choice_
    #else
    public abstract partial class RejectionOrRepairStatus34Choice_
    #endif
    {
    }
}
