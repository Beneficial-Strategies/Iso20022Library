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
    /// Specifies the type of advice requested for the transaction.
    /// </summary>
    [KnownType(typeof(AdviceType1Choice.Code))]
    [KnownType(typeof(AdviceType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdviceType1Choice.Code),nameof(AdviceType1Choice.Code))]
    [JsonDerivedType(typeof(AdviceType1Choice.Proprietary),nameof(AdviceType1Choice.Proprietary))]
    #endif
    [IsoId("_u3TXw9omEembTrt_WixjyQ")]
    [DisplayName("Advice Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdviceType1Choice_
    #else
    public abstract partial class AdviceType1Choice_
    #endif
    {
    }
}
