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
    [KnownType(typeof(SettlementDate22Choice.Date))]
    [KnownType(typeof(SettlementDate22Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate22Choice.Date),nameof(SettlementDate22Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate22Choice.DateCode),nameof(SettlementDate22Choice.DateCode))]
    #endif
    [IsoId("_5TmBm83yEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate22Choice_
    #else
    public abstract partial class SettlementDate22Choice_
    #endif
    {
    }
}
