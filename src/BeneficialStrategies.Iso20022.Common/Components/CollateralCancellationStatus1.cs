// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the status (that is accept or reject) of the CollateralManagementCancellationRequest message.
/// </summary>
[IsoId("_Unhixtp-Ed-ak6NoX_4Aeg_948055066")]
[DisplayName("Collateral Cancellation Status")]
public partial record CollateralCancellationStatus1
{
    #nullable enable
    
    /// <summary>
    /// Allows to provide a cancellation status using a code or a proprietary status.
    /// </summary>
    [IsoId("_Unhix9p-Ed-ak6NoX_4Aeg_-278481504")]
    [DisplayName("Collateral Status Code")]
    [IsoXmlTag("CollStsCd")]
    public required Status4Code CollateralStatusCode { get; init; } 
    
    /// <summary>
    /// Provides additional information on the status of the CollateralManagementCancellationRequest message.
    /// </summary>
    [IsoId("_UnhiyNp-Ed-ak6NoX_4Aeg_-1364198621")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Provides rejection reason and optionaly additional information.
    /// </summary>
    [IsoId("_UnrTwNp-Ed-ak6NoX_4Aeg_330113270")]
    [DisplayName("Rejection Details")]
    [IsoXmlTag("RjctnDtls")]
    public RejectionStatus2? RejectionDetails { get; init; } 
    
    
    #nullable disable
    
}
