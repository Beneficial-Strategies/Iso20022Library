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
/// Specifies the reason for the settlement fails as defined in the relevant regulation.
/// </summary>
[IsoId("_nWYekSGkEeqlG_HhjTmcZg")]
[DisplayName("Settlement Failure Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailureReason3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Average duration of settlement fails as number of days (difference between actual settlement date and intended settlement date, weighted for the value of the settlement fail).
    /// Usage: 
    /// Duration of fails is value based.
    /// </summary>
    [IsoId("_nXq4ASGkEeqlG_HhjTmcZg")]
    [DisplayName("Average Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgDrtn")]
    #endif
    [IsoXmlTag("AvrgDrtn")]
    [IsoSimpleType(IsoSimpleType.Max2Fraction1NonNegativeNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2Fraction1NonNegativeNumber? AverageDuration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AverageDuration { get; init; } 
    #else
    public System.UInt64? AverageDuration { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of the failure reasons.
    /// </summary>
    [IsoId("_nXq4AyGkEeqlG_HhjTmcZg")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    public ValueList<SettlementFailureReason2> Description { get; init; } = new ValueList<SettlementFailureReason2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _nXq4AyGkEeqlG_HhjTmcZg
    
    
    #nullable disable
    
}
