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
    [KnownType(typeof(SecuritiesTransactionType3Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType3Choice.Code),nameof(SecuritiesTransactionType3Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType3Choice.Proprietary),nameof(SecuritiesTransactionType3Choice.Proprietary))]
    #endif
    [IsoId("_QwUAotp-Ed-ak6NoX_4Aeg_645805426")]
    [DisplayName("Securities Transaction Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType3Choice_
    #else
    public abstract partial class SecuritiesTransactionType3Choice_
    #endif
    {
    }
}
