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
    [KnownType(typeof(CollateralValueCriteriaDefinition2Choice.QueryName))]
    [KnownType(typeof(CollateralValueCriteriaDefinition2Choice.NewCriteria))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition2Choice.QueryName),nameof(CollateralValueCriteriaDefinition2Choice.QueryName))]
    [JsonDerivedType(typeof(CollateralValueCriteriaDefinition2Choice.NewCriteria),nameof(CollateralValueCriteriaDefinition2Choice.NewCriteria))]
    #endif
    [IsoId("_zV1FIeFgEeWIA4E9cYSxxQ")]
    [DisplayName("Collateral Value Criteria Definition 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralValueCriteriaDefinition2Choice_
    #else
    public abstract partial class CollateralValueCriteriaDefinition2Choice_
    #endif
    {
    }
}
