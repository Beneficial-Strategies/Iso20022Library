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
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType37Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType37Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType37Choice.Code),nameof(SecuritiesTransactionType37Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType37Choice.Proprietary),nameof(SecuritiesTransactionType37Choice.Proprietary))]
    #endif
    [IsoId("_eTqacaUrEee4_75LDmHZiQ")]
    [DisplayName("Securities Transaction Type 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType37Choice_
    #else
    public abstract partial class SecuritiesTransactionType37Choice_
    #endif
    {
    }
}
