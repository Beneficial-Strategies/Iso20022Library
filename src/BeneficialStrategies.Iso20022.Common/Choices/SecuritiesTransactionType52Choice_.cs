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
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType52Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType52Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType52Choice.Code),nameof(SecuritiesTransactionType52Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType52Choice.Proprietary),nameof(SecuritiesTransactionType52Choice.Proprietary))]
    #endif
    [IsoId("_J4Cyy_fYEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType52Choice_
    #else
    public abstract partial class SecuritiesTransactionType52Choice_
    #endif
    {
    }
}
