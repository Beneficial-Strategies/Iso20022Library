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
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate32Choice.Date))]
    [KnownType(typeof(SettlementDate32Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate32Choice.Date),nameof(SettlementDate32Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate32Choice.DateCode),nameof(SettlementDate32Choice.DateCode))]
    #endif
    [IsoId("_vE8fa832Eee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate32Choice_
    #else
    public abstract partial class SettlementDate32Choice_
    #endif
    {
    }
}
