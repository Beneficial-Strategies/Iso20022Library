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
    [KnownType(typeof(SecuritiesTransactionType12Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType12Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType12Choice.Code),nameof(SecuritiesTransactionType12Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType12Choice.Proprietary),nameof(SecuritiesTransactionType12Choice.Proprietary))]
    #endif
    [IsoId("_8B67jf8qEeCQ-IWv9MUPeQ")]
    [DisplayName("Securities Transaction Type 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType12Choice_
    #else
    public abstract partial class SecuritiesTransactionType12Choice_
    #endif
    {
    }
}
