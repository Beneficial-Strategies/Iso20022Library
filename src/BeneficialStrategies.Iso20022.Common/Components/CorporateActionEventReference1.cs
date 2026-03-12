// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a linked corporate action event.
/// </summary>
[IsoId("_QxXJhNp-Ed-ak6NoX_4Aeg_-1181547020")]
[DisplayName("Corporate Action Event Reference")]
public partial record CorporateActionEventReference1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the linked corporate action event.
    /// </summary>
    [IsoId("_QxXJhdp-Ed-ak6NoX_4Aeg_-548700513")]
    [DisplayName("Event Identification")]
    [IsoXmlTag("EvtId")]
    public required CorporateActionEventReference1Choice_ EventIdentification { get; init; } 
    
    /// <summary>
    /// Specifies when this corporate action event is to be processed relative to a linked corporate action event.
    /// </summary>
    [IsoId("_QxXJhtp-Ed-ak6NoX_4Aeg_1794400947")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition1Choice_? LinkageType { get; init; } 
    
    
    #nullable disable
    
}
