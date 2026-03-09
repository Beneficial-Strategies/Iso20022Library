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
    [KnownType(typeof(RepairReason9Choice.Code))]
    [KnownType(typeof(RepairReason9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepairReason9Choice.Code),nameof(RepairReason9Choice.Code))]
    [JsonDerivedType(typeof(RepairReason9Choice.Proprietary),nameof(RepairReason9Choice.Proprietary))]
    #endif
    [IsoId("_A5mW8NokEeC60axPepSq7g_-1465147117")]
    [DisplayName("Repair Reason 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairReason9Choice_
    #else
    public abstract partial class RepairReason9Choice_
    #endif
    {
    }
}
