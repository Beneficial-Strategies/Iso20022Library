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
    /// Choice of formats for the EU dividend status type.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType2Choice.Code))]
    [KnownType(typeof(EUDividendStatusType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUDividendStatusType2Choice.Code),nameof(EUDividendStatusType2Choice.Code))]
    [JsonDerivedType(typeof(EUDividendStatusType2Choice.Proprietary),nameof(EUDividendStatusType2Choice.Proprietary))]
    #endif
    [IsoId("_PfdboTh8EeaH-93K5JKmzw")]
    [DisplayName("EU Dividend Status Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUDividendStatusType2Choice_
    #else
    public abstract partial class EUDividendStatusType2Choice_
    #endif
    {
    }
}
