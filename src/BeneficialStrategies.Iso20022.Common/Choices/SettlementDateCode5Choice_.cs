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
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode5Choice.Code))]
    [KnownType(typeof(SettlementDateCode5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDateCode5Choice.Code),nameof(SettlementDateCode5Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode5Choice.Proprietary),nameof(SettlementDateCode5Choice.Proprietary))]
    #endif
    [IsoId("_AcsYhdokEeC60axPepSq7g_-1982124379")]
    [DisplayName("Settlement Date Code 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDateCode5Choice_
    #else
    public abstract partial class SettlementDateCode5Choice_
    #endif
    {
    }
}
