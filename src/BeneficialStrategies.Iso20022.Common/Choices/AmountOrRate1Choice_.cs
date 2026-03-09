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
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate1Choice.Amount))]
    [KnownType(typeof(AmountOrRate1Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountOrRate1Choice.Amount),nameof(AmountOrRate1Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate1Choice.Rate),nameof(AmountOrRate1Choice.Rate))]
    #endif
    [IsoId("_Q-UncNp-Ed-ak6NoX_4Aeg_458279675")]
    [DisplayName("Amount Or Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountOrRate1Choice_
    #else
    public abstract partial class AmountOrRate1Choice_
    #endif
    {
    }
}
