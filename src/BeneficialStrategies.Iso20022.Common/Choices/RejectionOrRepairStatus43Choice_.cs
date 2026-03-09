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
    [KnownType(typeof(RejectionOrRepairStatus43Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus43Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionOrRepairStatus43Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus43Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus43Choice.Reason),nameof(RejectionOrRepairStatus43Choice.Reason))]
    #endif
    [IsoId("_Df01kStXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Or Repair Status 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionOrRepairStatus43Choice_
    #else
    public abstract partial class RejectionOrRepairStatus43Choice_
    #endif
    {
    }
}
