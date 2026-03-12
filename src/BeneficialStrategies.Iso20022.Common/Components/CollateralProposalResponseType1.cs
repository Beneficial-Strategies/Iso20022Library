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
[IsoId("_Un0dsdp-Ed-ak6NoX_4Aeg_2130391972")]
[DisplayName("Collateral Proposal Response Type")]
public partial record CollateralProposalResponseType1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    [IsoId("_Un0dstp-Ed-ak6NoX_4Aeg_218527511")]
    [DisplayName("Collateral Proposal Identification")]
    [IsoXmlTag("CollPrpslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CollateralProposalIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    [IsoId("_Un0ds9p-Ed-ak6NoX_4Aeg_-14002491")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CollateralProposalResponse1Code Type { get; init; } 
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    [IsoId("_Un0dtNp-Ed-ak6NoX_4Aeg_901549876")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_Un0dtdp-Ed-ak6NoX_4Aeg_-1564918581")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    [IsoId("_Un0dttp-Ed-ak6NoX_4Aeg_-1917789059")]
    [DisplayName("Rejection Information")]
    [IsoXmlTag("RjctnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RejectionInformation { get; init; } 
    
    
    #nullable disable
    
}
