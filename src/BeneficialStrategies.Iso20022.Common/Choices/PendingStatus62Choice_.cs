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
    [KnownType(typeof(PendingStatus62Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus62Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus62Choice.NoSpecifiedReason),nameof(PendingStatus62Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus62Choice.Reason),nameof(PendingStatus62Choice.Reason))]
    #endif
    [IsoId("_BVzBIQpIEeup4r-PFG2T5Q")]
    [DisplayName("Pending Status 62 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus62Choice_
    #else
    public abstract partial class PendingStatus62Choice_
    #endif
    {
    }
}
