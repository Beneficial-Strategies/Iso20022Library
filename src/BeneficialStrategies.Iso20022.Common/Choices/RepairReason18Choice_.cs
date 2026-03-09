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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason18Choice.Code))]
    [KnownType(typeof(RepairReason18Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepairReason18Choice.Code),nameof(RepairReason18Choice.Code))]
    [JsonDerivedType(typeof(RepairReason18Choice.Proprietary),nameof(RepairReason18Choice.Proprietary))]
    #endif
    [IsoId("_8QddO5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Reason 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairReason18Choice_
    #else
    public abstract partial class RepairReason18Choice_
    #endif
    {
    }
}
