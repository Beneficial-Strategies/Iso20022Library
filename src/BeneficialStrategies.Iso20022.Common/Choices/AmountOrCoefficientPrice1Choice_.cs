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
    /// Choice between an amount and a coefficient.
    /// </summary>
    [KnownType(typeof(AmountOrCoefficientPrice1Choice.Amount))]
    [KnownType(typeof(AmountOrCoefficientPrice1Choice.Coefficient))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountOrCoefficientPrice1Choice.Amount),nameof(AmountOrCoefficientPrice1Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice1Choice.Coefficient),nameof(AmountOrCoefficientPrice1Choice.Coefficient))]
    #endif
    [IsoId("_jBTw9O5NEeCisYr99QEiWA_-2039620670")]
    [DisplayName("Amount Or Coefficient Price 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountOrCoefficientPrice1Choice_
    #else
    public abstract partial class AmountOrCoefficientPrice1Choice_
    #endif
    {
    }
}
