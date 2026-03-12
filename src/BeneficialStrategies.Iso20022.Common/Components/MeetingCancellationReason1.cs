// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[IsoId("_RVRH0Np-Ed-ak6NoX_4Aeg_1713659135")]
[DisplayName("Meeting Cancellation Reason")]
public partial record MeetingCancellationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for cancelling a meeting in coded form.
    /// </summary>
    [IsoId("_RVRH0dp-Ed-ak6NoX_4Aeg_1713659137")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required MeetingCancellationReason2Code Code { get; init; } 
    
    /// <summary>
    /// Specifies the reason for cancelling a meeting in free text form.
    /// </summary>
    [IsoId("_RVRH0tp-Ed-ak6NoX_4Aeg_-1141003800")]
    [DisplayName("Extended Code")]
    [IsoXmlTag("XtndedCd")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedCode { get; init; } 
    
    /// <summary>
    /// Provides more information on the reason for cancelling a meeting in free format form.
    /// </summary>
    [IsoId("_RVRH09p-Ed-ak6NoX_4Aeg_1713659188")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? CancellationReason { get; init; } 
    
    
    #nullable disable
    
}
