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
    /// Choice between a standard code or proprietary code to specify whether the taxable income per share or per dividend is calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Code),nameof(TaxableIncomePerShareCalculatedFormat3Choice.Code))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary),nameof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary))]
    #endif
    [IsoId("_RaMwQUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Taxable Income Per Share Calculated Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxableIncomePerShareCalculatedFormat3Choice_
    #else
    public abstract partial class TaxableIncomePerShareCalculatedFormat3Choice_
    #endif
    {
    }
}
