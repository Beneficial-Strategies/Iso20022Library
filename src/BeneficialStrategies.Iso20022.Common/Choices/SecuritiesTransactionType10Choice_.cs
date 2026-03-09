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
    [KnownType(typeof(SecuritiesTransactionType10Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType10Choice.Code),nameof(SecuritiesTransactionType10Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType10Choice.Proprietary),nameof(SecuritiesTransactionType10Choice.Proprietary))]
    #endif
    [IsoId("_PlajS_vmEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType10Choice_
    #else
    public abstract partial class SecuritiesTransactionType10Choice_
    #endif
    {
    }
}
