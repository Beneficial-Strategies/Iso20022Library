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
    /// Choice of formats for the specification of a distribution strategy.
    /// </summary>
    [KnownType(typeof(DistributionStrategy1Choice.Code))]
    [KnownType(typeof(DistributionStrategy1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DistributionStrategy1Choice.Code),nameof(DistributionStrategy1Choice.Code))]
    [JsonDerivedType(typeof(DistributionStrategy1Choice.Proprietary),nameof(DistributionStrategy1Choice.Proprietary))]
    #endif
    [IsoId("_1jAiQDcgEeidBoT_PugKiA")]
    [DisplayName("Distribution Strategy 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionStrategy1Choice_
    #else
    public abstract partial class DistributionStrategy1Choice_
    #endif
    {
    }
}
