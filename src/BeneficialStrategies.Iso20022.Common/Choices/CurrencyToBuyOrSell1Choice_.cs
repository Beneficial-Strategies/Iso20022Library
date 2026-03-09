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
    /// Choice of counterparty type.
    /// </summary>
    [KnownType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToBuy))]
    [KnownType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToSell))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToBuy),nameof(CurrencyToBuyOrSell1Choice.CurrencyToBuy))]
    [JsonDerivedType(typeof(CurrencyToBuyOrSell1Choice.CurrencyToSell),nameof(CurrencyToBuyOrSell1Choice.CurrencyToSell))]
    #endif
    [IsoId("_QsvIMdp-Ed-ak6NoX_4Aeg_-947619938")]
    [DisplayName("Currency To Buy Or Sell 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrencyToBuyOrSell1Choice_
    #else
    public abstract partial class CurrencyToBuyOrSell1Choice_
    #endif
    {
    }
}
