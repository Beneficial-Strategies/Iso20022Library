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
    /// Choice between an amount with or without the currency.
    /// </summary>
    [KnownType(typeof(Amount3Choice.AmountWithCurrency))]
    [KnownType(typeof(Amount3Choice.AmountWithoutCurrency))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Amount3Choice.AmountWithCurrency),nameof(Amount3Choice.AmountWithCurrency))]
    [JsonDerivedType(typeof(Amount3Choice.AmountWithoutCurrency),nameof(Amount3Choice.AmountWithoutCurrency))]
    #endif
    [IsoId("_750BhaMgEeCJ6YNENx4h-w_-899399961")]
    [DisplayName("Amount 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Amount3Choice_
    #else
    public abstract partial class Amount3Choice_
    #endif
    {
    }
}
