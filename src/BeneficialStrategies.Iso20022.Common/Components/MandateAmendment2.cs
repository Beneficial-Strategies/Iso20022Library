// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_tlOvAVkyEeGeoaLUQk__nA_-1635096845")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment2
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_tlOvAlkyEeGeoaLUQk__nA_1370840360")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_tlOvA1kyEeGeoaLUQk__nA_675034051")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; } 
    
    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_tlX48FkyEeGeoaLUQk__nA_454715992")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate3 Mandate { get; init; } 
    
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_tlX48VkyEeGeoaLUQk__nA_1435976193")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; } 
    
    
    #nullable disable
    
}
