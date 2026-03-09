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
    /// Choice between an amount or rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate3Choice.Amount))]
    [KnownType(typeof(AmountOrRate3Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountOrRate3Choice.Amount),nameof(AmountOrRate3Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate3Choice.Rate),nameof(AmountOrRate3Choice.Rate))]
    #endif
    [IsoId("_cL-fQQauEeS3lpTattq7hg")]
    [DisplayName("Amount Or Rate 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountOrRate3Choice_
    #else
    public abstract partial class AmountOrRate3Choice_
    #endif
    {
    }
}
