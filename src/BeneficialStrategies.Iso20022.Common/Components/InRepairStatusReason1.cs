// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a status in repair.
/// </summary>
[IsoId("_Ut7sx9p-Ed-ak6NoX_4Aeg_-41189078")]
[DisplayName("In Repair Status Reason")]
public partial record InRepairStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for an in repair status in free format text.
    /// </summary>
    [IsoId("_UuFdwNp-Ed-ak6NoX_4Aeg_-41189059")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
