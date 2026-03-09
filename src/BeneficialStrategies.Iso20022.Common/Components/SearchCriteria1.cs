// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligibility parameters for a transaction to be part of transaction report.
/// </summary>
[IsoId("_5HATgN6PEeiwsev40qZGEQ")]
[DisplayName("Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of criteria following the OR logic.
    /// </summary>
    [IsoId("_APMeMN6QEeiwsev40qZGEQ")]
    [DisplayName("Search Or")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchOr")]
    #endif
    [IsoXmlTag("SchOr")]
    public ValueList<SearchOr1> SearchOr { get; init; } = new ValueList<SearchOr1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _APMeMN6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
