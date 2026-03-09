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
    /// Definition of the collateral value query criteria.
    /// </summary>
    [KnownType(typeof(CollateralValueCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition1Choice.NewCriteria))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition1Choice.QueryName),nameof(CollateralValueCriteriaDefinition1Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition1Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition1Choice.NewCriteria))]
    #endif
    [IsoId("_jJgDo-5NEeCisYr99QEiWA_-333364953")]
    [DisplayName("Collateral Value Criteria Definition 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralValueCriteriaDefinition1Choice_
    #else
    public abstract partial class CollateralValueCriteriaDefinition1Choice_
    #endif
    {
    }
}
