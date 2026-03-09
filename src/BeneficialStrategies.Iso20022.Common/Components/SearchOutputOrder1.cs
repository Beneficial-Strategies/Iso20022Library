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
/// Indicates the ordering in which the resulting transaction reports should be returned.
/// </summary>
[IsoId("_s9PP4N6QEeiwsev40qZGEQ")]
[DisplayName("Search Output Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SearchOutputOrder1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Ordering criteria for the transaction report.
    /// </summary>
    [IsoId("_0aWhsN6QEeiwsev40qZGEQ")]
    [DisplayName("Criteria Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CritOrdr")]
    #endif
    [IsoXmlTag("CritOrdr")]
    public ValueList<CriteriaOrder1> CriteriaOrder { get; init; } = new ValueList<CriteriaOrder1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _0aWhsN6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
