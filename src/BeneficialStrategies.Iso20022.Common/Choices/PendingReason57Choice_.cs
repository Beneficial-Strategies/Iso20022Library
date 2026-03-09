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
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason57Choice.Code))]
    [KnownType(typeof(PendingReason57Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason57Choice.Code),nameof(PendingReason57Choice.Code))]
    [JsonDerivedType(typeof(PendingReason57Choice.Proprietary),nameof(PendingReason57Choice.Proprietary))]
    #endif
    [IsoId("_FxTUU-6KEeqc-LCjwLsUVg")]
    [DisplayName("Pending Reason 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason57Choice_
    #else
    public abstract partial class PendingReason57Choice_
    #endif
    {
    }
}
