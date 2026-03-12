// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructs the POI (Point Of Interaction) how to contact the host of the terminal management system (TMS), to initiate the maintenance of the terminal.
/// </summary>
[IsoId("_TGSgXAEcEeCQm6a_G2yO_w_-983555179")]
[DisplayName("TMS Trigger")]
public partial record TMSTrigger1
{
    #nullable enable
    
    /// <summary>
    /// Level of urgency in contacting the maintenance.
    /// </summary>
    [IsoId("_TGSgXQEcEeCQm6a_G2yO_w_-325386480")]
    [DisplayName("TMS Contact Level")]
    [IsoXmlTag("TMSCtctLvl")]
    public required TMSContactLevel1Code TMSContactLevel { get; init; } 
    
    /// <summary>
    /// Identification of the host to contact for the maintenance.
    /// </summary>
    [IsoId("_TGSgXgEcEeCQm6a_G2yO_w_-579683190")]
    [DisplayName("TMS Identification")]
    [IsoXmlTag("TMSId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TMSIdentification { get; init; } 
    
    /// <summary>
    /// Date and time for calling the maintenance.
    /// </summary>
    [IsoId("_TGSgXwEcEeCQm6a_G2yO_w_-1677507172")]
    [DisplayName("TMS Contact Date Time")]
    [IsoXmlTag("TMSCtctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TMSContactDateTime { get; init; } 
    
    
    #nullable disable
    
}
