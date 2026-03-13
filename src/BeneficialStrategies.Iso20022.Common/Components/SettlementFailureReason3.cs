// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for the settlement fails as defined in the relevant regulation.
/// </summary>
[IsoId("_nWYekSGkEeqlG_HhjTmcZg")]
[DisplayName("Settlement Failure Reason")]
public partial record SettlementFailureReason3
{
    #nullable enable
    
    /// <summary>
    /// Average duration of settlement fails as number of days (difference between actual settlement date and intended settlement date, weighted for the value of the settlement fail).
    /// Usage: 
    /// Duration of fails is value based.
    /// </summary>
    [IsoId("_nXq4ASGkEeqlG_HhjTmcZg")]
    [DisplayName("Average Duration")]
    [IsoXmlTag("AvrgDrtn")]
    [IsoSimpleType(IsoSimpleType.Max2Fraction1NonNegativeNumber)]
    public IsoMax2Fraction1NonNegativeNumber? AverageDuration { get; init; } 
    
    /// <summary>
    /// Detailed description of the failure reasons.
    /// </summary>
    [IsoId("_nXq4AyGkEeqlG_HhjTmcZg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<SettlementFailureReason2> Description { get; init; } = [];
    // ID for the above is _nXq4AyGkEeqlG_HhjTmcZg
    
    
    #nullable disable
    
}
