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
    [KnownType(typeof(SecuritiesTransactionType51Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType51Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType51Choice.Code),nameof(SecuritiesTransactionType51Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType51Choice.Proprietary),nameof(SecuritiesTransactionType51Choice.Proprietary))]
    #endif
    [IsoId("_5-eRf_fXEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType51Choice_
    #else
    public abstract partial class SecuritiesTransactionType51Choice_
    #endif
    {
    }
}
