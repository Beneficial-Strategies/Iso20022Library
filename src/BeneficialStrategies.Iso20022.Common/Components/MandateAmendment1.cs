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
[IsoId("_RBcz9tp-Ed-ak6NoX_4Aeg_-453440412")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_RBcz99p-Ed-ak6NoX_4Aeg_344631630")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the amendment reason.
    /// </summary>
    [IsoId("_RBcz-Np-Ed-ak6NoX_4Aeg_-995812636")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required AmendmentReasonInformation1 AmendmentReason { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide the amended mandate data.
    /// </summary>
    [IsoId("_RBmk8Np-Ed-ak6NoX_4Aeg_-1140806205")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required MandateInformation3 Mandate { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    [IsoId("_RBmk8dp-Ed-ak6NoX_4Aeg_75619015")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate1Choice_ OriginalMandate { get; init; } 
    
    
    #nullable disable
    
}
