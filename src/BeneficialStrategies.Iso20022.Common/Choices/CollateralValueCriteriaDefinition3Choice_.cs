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
    [KnownType(typeof(CollateralValueCriteriaDefinition3Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition3Choice.NewCriteria))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition3Choice.QueryName),nameof(CollateralValueCriteriaDefinition3Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition3Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition3Choice.NewCriteria))]
    #endif
    [IsoId("__ksIgTpsEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Criteria Definition 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralValueCriteriaDefinition3Choice_
    #else
    public abstract partial class CollateralValueCriteriaDefinition3Choice_
    #endif
    {
    }
}
