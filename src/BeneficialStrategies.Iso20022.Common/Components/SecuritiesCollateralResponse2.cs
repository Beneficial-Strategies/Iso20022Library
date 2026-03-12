// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides more details on the response such as the response type, the collateral identification, and optionally further details in case of rejection.
/// </summary>
[IsoId("_w3eiyStIEeyOa655cLd-DQ")]
[DisplayName("Securities Collateral Response")]
public partial record SecuritiesCollateralResponse2
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_xPxG8ytIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_xPxG9StIEeyOa655cLd-DQ")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; } 
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    [IsoId("_xPxG9ytIEeyOa655cLd-DQ")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_xPxG-StIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectionReason68Code? RejectionReason { get; init; } 
    
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    [IsoId("_xPxG-ytIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Information")]
    [IsoXmlTag("RjctnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RejectionInformation { get; init; } 
    
    
    #nullable disable
    
}
