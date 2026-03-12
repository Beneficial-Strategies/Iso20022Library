// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the response for a collateral proposal.
/// </summary>
[IsoId("_vsvQMWTUEeSSTJlMfOKFsA")]
[DisplayName("Collateral Proposal Response Type")]
public partial record CollateralProposalResponseType2
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    [IsoId("_wJv8U2TUEeSSTJlMfOKFsA")]
    [DisplayName("Collateral Proposal Identification")]
    [IsoXmlTag("CollPrpslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CollateralProposalIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    [IsoId("_wJv8VWTUEeSSTJlMfOKFsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CollateralProposalResponse1Code Type { get; init; } 
    
    /// <summary>
    /// Provides response details for each of the proposed collateral pieces.
    /// </summary>
    [IsoId("_cpnaMGT4EeSnseycwS8fpA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required CollateralResponse1 Response { get; init; } 
    
    
    #nullable disable
    
}
