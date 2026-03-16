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
[IsoId("_cvIIYV9-EeSMgPeFpRHeJw")]
[DisplayName("Collateral")]
public record Collateral7
{
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    [IsoId("_dL_DgV9-EeSMgPeFpRHeJw")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    [IsoId("_dL_Dg19-EeSMgPeFpRHeJw")]
    [DisplayName("Margin Call Response Identification")]
    [IsoXmlTag("MrgnCallRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarginCallResponseIdentification { get; init; }

    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    [IsoId("_dL_DhV9-EeSMgPeFpRHeJw")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    [IsoId("_dL_Dh19-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal Response Identification")]
    [IsoXmlTag("CollPrpslRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; }

    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_dL_DiV9-EeSMgPeFpRHeJw")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral3? SecuritiesCollateral { get; init; }

    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_dL_Di19-EeSMgPeFpRHeJw")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral2? CashCollateral { get; init; }

    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_dL_DjV9-EeSMgPeFpRHeJw")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral2? OtherCollateral { get; init; }
}
