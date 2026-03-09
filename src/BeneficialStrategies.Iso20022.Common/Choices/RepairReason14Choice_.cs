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
    [KnownType(typeof(RepairReason14Choice.Code))]
    [KnownType(typeof(RepairReason14Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepairReason14Choice.Code),nameof(RepairReason14Choice.Code))]
    [JsonDerivedType(typeof(RepairReason14Choice.Proprietary),nameof(RepairReason14Choice.Proprietary))]
    #endif
    [IsoId("_6P_aDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Reason 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairReason14Choice_
    #else
    public abstract partial class RepairReason14Choice_
    #endif
    {
    }
}
