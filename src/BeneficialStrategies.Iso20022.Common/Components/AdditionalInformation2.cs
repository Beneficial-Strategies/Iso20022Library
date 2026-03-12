// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information about a request (e.g. financing request).
/// </summary>
[IsoId("_Rhyg6Np-Ed-ak6NoX_4Aeg_1542618603")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the waiver.
    /// </summary>
    [IsoId("_Rhyg6dp-Ed-ak6NoX_4Aeg_828459095")]
    [DisplayName("Order Waiver Reason")]
    [IsoXmlTag("OrdrWvrRsn")]
    public OrderWaiverReason1Choice_? OrderWaiverReason { get; init; } 
    
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    [IsoId("_Rh7q0Np-Ed-ak6NoX_4Aeg_1542618912")]
    [DisplayName("Information Value")]
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InformationValue { get; init; } 
    
    
    #nullable disable
    
}
