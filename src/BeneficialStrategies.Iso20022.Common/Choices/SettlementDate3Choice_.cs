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
    [KnownType(typeof(SettlementDate3Choice.Date))]
    [KnownType(typeof(SettlementDate3Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate3Choice.Date),nameof(SettlementDate3Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate3Choice.DateCode),nameof(SettlementDate3Choice.DateCode))]
    #endif
    [IsoId("_Qsl-Rtp-Ed-ak6NoX_4Aeg_228808861")]
    [DisplayName("Settlement Date 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate3Choice_
    #else
    public abstract partial class SettlementDate3Choice_
    #endif
    {
    }
}
