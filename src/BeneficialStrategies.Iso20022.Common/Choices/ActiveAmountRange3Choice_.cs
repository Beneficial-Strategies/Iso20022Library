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
    /// Choice between a range of amount values with or without the currency.
    /// </summary>
    [KnownType(typeof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange))]
    [KnownType(typeof(ActiveAmountRange3Choice.CurrencyAndAmountRange))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange),nameof(ActiveAmountRange3Choice.ImpliedCurrencyAndAmountRange))]
    [JsonDerivedType(typeof(ActiveAmountRange3Choice.CurrencyAndAmountRange),nameof(ActiveAmountRange3Choice.CurrencyAndAmountRange))]
    #endif
    [IsoId("_OnGKkZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Active Amount Range 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ActiveAmountRange3Choice_
    #else
    public abstract partial class ActiveAmountRange3Choice_
    #endif
    {
    }
}
