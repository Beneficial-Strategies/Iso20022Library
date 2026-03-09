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
    /// Choice of formats for taxable income per share calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculated2Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculated2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated2Choice.Code),nameof(TaxableIncomePerShareCalculated2Choice.Code))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated2Choice.Proprietary),nameof(TaxableIncomePerShareCalculated2Choice.Proprietary))]
    #endif
    [IsoId("_wM39wThgEeamLZQeccJa7w")]
    [DisplayName("Taxable Income Per Share Calculated 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxableIncomePerShareCalculated2Choice_
    #else
    public abstract partial class TaxableIncomePerShareCalculated2Choice_
    #endif
    {
    }
}
