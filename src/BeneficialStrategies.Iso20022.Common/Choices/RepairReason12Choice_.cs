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
    [KnownType(typeof(RepairReason12Choice.Code))]
    [KnownType(typeof(RepairReason12Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepairReason12Choice.Code),nameof(RepairReason12Choice.Code))]
    [JsonDerivedType(typeof(RepairReason12Choice.Proprietary),nameof(RepairReason12Choice.Proprietary))]
    #endif
    [IsoId("_ja_PsTw5EeW3QqUkIQtIUA")]
    [DisplayName("Repair Reason 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairReason12Choice_
    #else
    public abstract partial class RepairReason12Choice_
    #endif
    {
    }
}
