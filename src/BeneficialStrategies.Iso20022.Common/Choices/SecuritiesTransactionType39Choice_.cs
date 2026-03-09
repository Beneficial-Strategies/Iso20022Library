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
    [KnownType(typeof(SecuritiesTransactionType39Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType39Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType39Choice.Code),nameof(SecuritiesTransactionType39Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType39Choice.Proprietary),nameof(SecuritiesTransactionType39Choice.Proprietary))]
    #endif
    [IsoId("_VKmjf83zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Transaction Type 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType39Choice_
    #else
    public abstract partial class SecuritiesTransactionType39Choice_
    #endif
    {
    }
}
