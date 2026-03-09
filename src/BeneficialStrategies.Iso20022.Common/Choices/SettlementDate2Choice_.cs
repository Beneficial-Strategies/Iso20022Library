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
    [KnownType(typeof(SettlementDate2Choice.Date))]
    [KnownType(typeof(SettlementDate2Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate2Choice.Date),nameof(SettlementDate2Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate2Choice.DateCode),nameof(SettlementDate2Choice.DateCode))]
    #endif
    [IsoId("_QurB59p-Ed-ak6NoX_4Aeg_419726603")]
    [DisplayName("Settlement Date 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate2Choice_
    #else
    public abstract partial class SettlementDate2Choice_
    #endif
    {
    }
}
