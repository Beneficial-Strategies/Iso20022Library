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
/// List of criteria following the OR logic.
/// </summary>
[IsoId("_BBbMYN6QEeiwsev40qZGEQ")]
[DisplayName("Search Or")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SearchOr1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of criteria following the AND logic.
    /// </summary>
    [IsoId("_InLc0N6QEeiwsev40qZGEQ")]
    [DisplayName("Search And")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchAnd")]
    #endif
    [IsoXmlTag("SchAnd")]
    public ValueList<SearchAnd1> SearchAnd { get; init; } = new ValueList<SearchAnd1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _InLc0N6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
