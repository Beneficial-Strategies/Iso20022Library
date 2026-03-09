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
    [KnownType(typeof(SecuritiesTransactionType35Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType35Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType35Choice.Code),nameof(SecuritiesTransactionType35Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType35Choice.Proprietary),nameof(SecuritiesTransactionType35Choice.Proprietary))]
    #endif
    [IsoId("_D5OqYZwyEeazcsnODTksnQ")]
    [DisplayName("Securities Transaction Type 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType35Choice_
    #else
    public abstract partial class SecuritiesTransactionType35Choice_
    #endif
    {
    }
}
