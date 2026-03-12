// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason for rejection and/or additional information if required.
/// </summary>
[IsoId("_Q7yQ1Np-Ed-ak6NoX_4Aeg_1144843079")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason4
{
    #nullable enable
    
    /// <summary>
    /// Detailed description of the rejection reason.
    /// </summary>
    [IsoId("_Q7yQ1dp-Ed-ak6NoX_4Aeg_1178093094")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectionReason3Code ReasonCode { get; init; } 
    
    /// <summary>
    /// Additional information related to the rejection and meant to allow for the precise identification of the rejection reason.
    /// </summary>
    [IsoId("_Q7yQ1tp-Ed-ak6NoX_4Aeg_1216879611")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
