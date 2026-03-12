// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The process of notifying of an upcoming corporate action. It provides corporate action details including the different options.
/// </summary>
[IsoId("_UKK4Ztp-Ed-ak6NoX_4Aeg_1829134178")]
[DisplayName("Corporate Action Event Status")]
public partial record CorporateActionEventStatus1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the details provided about an event are complete or incomplete.
    /// </summary>
    [IsoId("_UKK4Z9p-Ed-ak6NoX_4Aeg_1527495156")]
    [DisplayName("Event Completeness Status")]
    [IsoXmlTag("EvtCmpltnsSts")]
    public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    
    /// <summary>
    /// Indicates the status of the occurrence of an event.
    /// </summary>
    [IsoId("_UKK4aNp-Ed-ak6NoX_4Aeg_1457310397")]
    [DisplayName("Event Confirmation Status")]
    [IsoXmlTag("EvtConfSts")]
    public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    
    
    #nullable disable
    
}
