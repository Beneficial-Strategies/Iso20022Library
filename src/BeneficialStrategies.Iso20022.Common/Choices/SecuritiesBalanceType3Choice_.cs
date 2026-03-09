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
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType3Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesBalanceType3Choice.Code),nameof(SecuritiesBalanceType3Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType3Choice.Proprietary),nameof(SecuritiesBalanceType3Choice.Proprietary))]
    #endif
    [IsoId("_QtCDJtp-Ed-ak6NoX_4Aeg_1544987525")]
    [DisplayName("Securities Balance Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType3Choice_
    #else
    public abstract partial class SecuritiesBalanceType3Choice_
    #endif
    {
    }
}
