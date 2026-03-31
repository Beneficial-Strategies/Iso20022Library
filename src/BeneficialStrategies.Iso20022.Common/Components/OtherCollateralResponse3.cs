// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides more details on the response such as the response type, the collateral identification, and optionally further details in case of rejection.
/// </summary>
[IsoId("_6nGpwStIEeyOa655cLd-DQ")]
[DisplayName("Other Collateral Response")]
public record OtherCollateralResponse3
{
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    [IsoId("_6_Fr8ytIEeyOa655cLd-DQ")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; }

    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_6_Fr9StIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; }

    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_6_Fr9ytIEeyOa655cLd-DQ")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; }

    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_6_Fr-StIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectionReason68Code? RejectionReason { get; init; }

    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    [IsoId("_6_Fr-ytIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Information")]
    [IsoXmlTag("RjctnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RejectionInformation { get; init; }
}
