// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the time-out reason.
/// </summary>
[IsoId("_Utx7wNp-Ed-ak6NoX_4Aeg_150550546")]
[DisplayName("Time Out Event")]
public partial record TimeOutEvent1
{
    #nullable enable
    
    /// <summary>
    /// Specifies in coded form the reason for the time-out notification.
    /// </summary>
    [IsoId("_Utx7wdp-Ed-ak6NoX_4Aeg_295543230")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TimeOut1Code Type { get; init; } 
    
    /// <summary>
    /// Additional information on the reason for the time-out.
    /// </summary>
    [IsoId("_Utx7wtp-Ed-ak6NoX_4Aeg_237361529")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
