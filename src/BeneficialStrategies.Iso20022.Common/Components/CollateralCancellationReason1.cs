// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for which the collateral message has been cancelled.
/// </summary>
[IsoId("_UnhiwNp-Ed-ak6NoX_4Aeg_-540863751")]
[DisplayName("Collateral Cancellation Reason")]
public partial record CollateralCancellationReason1
{
    #nullable enable
    
    /// <summary>
    /// Allows to provides additional information on the cancellation reason.
    /// </summary>
    [IsoId("_Unhiwdp-Ed-ak6NoX_4Aeg_-1001218572")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Allows to provide a cancellation reason using a code or proprietary reason.
    /// </summary>
    [IsoId("_Unhiwtp-Ed-ak6NoX_4Aeg_1328732613")]
    [DisplayName("Cancellation Reason Code")]
    [IsoXmlTag("CxlRsnCd")]
    public required CollateralCancellationType1Choice_ CancellationReasonCode { get; init; } 
    
    
    #nullable disable
    
}
