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
    [KnownType(typeof(Amount2Choice.AmountWithoutCurrency))]
    [KnownType(typeof(Amount2Choice.AmountWithCurrency))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Amount2Choice.AmountWithoutCurrency),nameof(Amount2Choice.AmountWithoutCurrency))]
    [JsonDerivedType(typeof(Amount2Choice.AmountWithCurrency),nameof(Amount2Choice.AmountWithCurrency))]
    #endif
    [IsoId("_75DzlKMgEeCJ6YNENx4h-w_890446015")]
    [DisplayName("Amount 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Amount2Choice_
    #else
    public abstract partial class Amount2Choice_
    #endif
    {
    }
}
