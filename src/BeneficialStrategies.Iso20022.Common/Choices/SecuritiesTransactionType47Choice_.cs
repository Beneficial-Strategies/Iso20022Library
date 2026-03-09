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
    [KnownType(typeof(SecuritiesTransactionType47Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType47Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType47Choice.Code),nameof(SecuritiesTransactionType47Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType47Choice.Proprietary),nameof(SecuritiesTransactionType47Choice.Proprietary))]
    #endif
    [IsoId("_qeGLEdYYEeiHVOfMzoKxnA")]
    [DisplayName("Securities Transaction Type 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType47Choice_
    #else
    public abstract partial class SecuritiesTransactionType47Choice_
    #endif
    {
    }
}
