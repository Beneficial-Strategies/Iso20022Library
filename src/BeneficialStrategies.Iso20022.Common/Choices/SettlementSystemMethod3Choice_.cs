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
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod3Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementSystemMethod3Choice.Code),nameof(SettlementSystemMethod3Choice.Code))]
    [JsonDerivedType(typeof(SettlementSystemMethod3Choice.Proprietary),nameof(SettlementSystemMethod3Choice.Proprietary))]
    #endif
    [IsoId("_AZQqAdokEeC60axPepSq7g_1949401070")]
    [DisplayName("Settlement System Method 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementSystemMethod3Choice_
    #else
    public abstract partial class SettlementSystemMethod3Choice_
    #endif
    {
    }
}
