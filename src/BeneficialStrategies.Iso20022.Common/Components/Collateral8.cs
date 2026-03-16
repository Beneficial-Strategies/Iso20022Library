// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral that will be either delivered, returned or both.
/// </summary>
[IsoId("_esk7IWNxEeSIWbZ6by9dnA")]
[DisplayName("Collateral")]
public record Collateral8
{
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    [IsoId("_fKCTMWNxEeSIWbZ6by9dnA")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    [IsoId("_fKCTM2NxEeSIWbZ6by9dnA")]
    [DisplayName("Margin Call Response Identification")]
    [IsoXmlTag("MrgnCallRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarginCallResponseIdentification { get; init; }

    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    [IsoId("_fKCTNWNxEeSIWbZ6by9dnA")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    [IsoId("_fKCTN2NxEeSIWbZ6by9dnA")]
    [DisplayName("Collateral Proposal Response Identification")]
    [IsoXmlTag("CollPrpslRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; }

    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_fKCTOWNxEeSIWbZ6by9dnA")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public ValueList<SecuritiesCollateral3> SecuritiesCollateral { get; init; } = [];

    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_fKCTO2NxEeSIWbZ6by9dnA")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public ValueList<CashCollateral3> CashCollateral { get; init; } = [];

    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_fKCTPWNxEeSIWbZ6by9dnA")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public ValueList<OtherCollateral2> OtherCollateral { get; init; } = [];
}
