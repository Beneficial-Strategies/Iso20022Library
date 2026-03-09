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
    [KnownType(typeof(SettlementDate20Choice.Date))]
    [KnownType(typeof(SettlementDate20Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate20Choice.Date),nameof(SettlementDate20Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate20Choice.DateCode),nameof(SettlementDate20Choice.DateCode))]
    #endif
    [IsoId("_qImeT83yEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate20Choice_
    #else
    public abstract partial class SettlementDate20Choice_
    #endif
    {
    }
}
