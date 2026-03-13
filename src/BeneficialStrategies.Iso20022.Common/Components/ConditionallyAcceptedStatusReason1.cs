// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a conditionally accepted status.
/// </summary>
[IsoId("_UyQMEdp-Ed-ak6NoX_4Aeg_524981898")]
[DisplayName("Conditionally Accepted Status Reason")]
public partial record ConditionallyAcceptedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a conditionally accepted status in structured form.
    /// </summary>
    [IsoId("_UyQMEtp-Ed-ak6NoX_4Aeg_524981907")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    [MinLength(1)]
    [MaxLength(4)]
    public SimpleValueList<ConditionallyAcceptedStatusReason1Code> Structured { get; init; } = [];
    
    /// <summary>
    /// Reason for a conditionally accepted status in free format text.
    /// </summary>
    [IsoId("_UyQME9p-Ed-ak6NoX_4Aeg_524982157")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
