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
    [KnownType(typeof(SecuritiesTransactionType2Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType2Choice.Code),nameof(SecuritiesTransactionType2Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType2Choice.Proprietary),nameof(SecuritiesTransactionType2Choice.Proprietary))]
    #endif
    [IsoId("_QtevF9p-Ed-ak6NoX_4Aeg_-529584274")]
    [DisplayName("Securities Transaction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType2Choice_
    #else
    public abstract partial class SecuritiesTransactionType2Choice_
    #endif
    {
    }
}
