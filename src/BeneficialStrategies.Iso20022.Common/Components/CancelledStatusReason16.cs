// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a cancelled status.
/// </summary>
[IsoId("_E11NIUHVEeasdbKMiqizqA")]
[DisplayName("Cancelled Status Reason")]
public partial record CancelledStatusReason16
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_YZCuGUHVEeasdbKMiqizqA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancelledReason12Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the cancelled status.
    /// </summary>
    [IsoId("_YZDVI0HVEeasdbKMiqizqA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
