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
    [KnownType(typeof(SettlementDate12Choice.Date))]
    [KnownType(typeof(SettlementDate12Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate12Choice.Date),nameof(SettlementDate12Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate12Choice.DateCode),nameof(SettlementDate12Choice.DateCode))]
    #endif
    [IsoId("_5TGUn5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate12Choice_
    #else
    public abstract partial class SettlementDate12Choice_
    #endif
    {
    }
}
