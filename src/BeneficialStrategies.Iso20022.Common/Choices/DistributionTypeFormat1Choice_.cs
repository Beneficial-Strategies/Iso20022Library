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
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat1Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DistributionTypeFormat1Choice.Code),nameof(DistributionTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat1Choice.Proprietary),nameof(DistributionTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q3nihdp-Ed-ak6NoX_4Aeg_2019414237")]
    [DisplayName("Distribution Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionTypeFormat1Choice_
    #else
    public abstract partial class DistributionTypeFormat1Choice_
    #endif
    {
    }
}
