// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date parameters.
/// </summary>
[IsoId("_98LLAnltEeG7BsjMvd1mEw_1203331503")]
[DisplayName("Date Information")]
public partial record DateInformation1
{
    #nullable enable
    
    /// <summary>
    /// Date on which a recurrent date will commence.
    /// </summary>
    [IsoId("_98LLA3ltEeG7BsjMvd1mEw_-900960723")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; } 
    
    /// <summary>
    /// Specifies the regularity of the trigger date.
    /// </summary>
    [IsoId("_98LLBHltEeG7BsjMvd1mEw_-1516871632")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required ExternalDateFrequency1Code Frequency { get; init; } 
    
    /// <summary>
    /// Maximum number of trigger date occurrence cycles.
    /// </summary>
    [IsoId("_98LLBXltEeG7BsjMvd1mEw_-1181408529")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Number { get; init; } 
    
    
    #nullable disable
    
}
