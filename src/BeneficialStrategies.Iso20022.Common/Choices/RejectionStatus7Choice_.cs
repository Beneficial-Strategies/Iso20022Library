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
    [KnownType(typeof(RejectionStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus7Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus7Choice.NoSpecifiedReason),nameof(RejectionStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus7Choice.Reason),nameof(RejectionStatus7Choice.Reason))]
    #endif
    [IsoId("_0j0X4wlIEeGATtfOBToyew_1026821782")]
    [DisplayName("Rejection Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus7Choice_
    #else
    public abstract partial class RejectionStatus7Choice_
    #endif
    {
    }
}
