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
    [KnownType(typeof(AmountOrRate4Choice.Amount))]
    [KnownType(typeof(AmountOrRate4Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountOrRate4Choice.Amount),nameof(AmountOrRate4Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate4Choice.Rate),nameof(AmountOrRate4Choice.Rate))]
    #endif
    [IsoId("_xN0ggANwEe2-vqzwMUAewg")]
    [DisplayName("Amount Or Rate 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountOrRate4Choice_
    #else
    public abstract partial class AmountOrRate4Choice_
    #endif
    {
    }
}
