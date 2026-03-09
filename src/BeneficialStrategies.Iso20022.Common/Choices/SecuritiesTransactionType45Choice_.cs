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
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType45Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType45Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType45Choice.Code),nameof(SecuritiesTransactionType45Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType45Choice.Proprietary),nameof(SecuritiesTransactionType45Choice.Proprietary))]
    #endif
    [IsoId("_m2WakdExEeiO-eodGv5iKQ")]
    [DisplayName("Securities Transaction Type 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType45Choice_
    #else
    public abstract partial class SecuritiesTransactionType45Choice_
    #endif
    {
    }
}
