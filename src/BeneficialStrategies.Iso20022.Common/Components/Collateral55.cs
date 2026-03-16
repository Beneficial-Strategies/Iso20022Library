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
[IsoId("_7nrqJSqREeyR9JrVGfaMKw")]
[DisplayName("Collateral")]
public record Collateral55
{
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    [IsoId("_7_-OUSqREeyR9JrVGfaMKw")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    [IsoId("_7_-OUyqREeyR9JrVGfaMKw")]
    [DisplayName("Margin Call Response Identification")]
    [IsoXmlTag("MrgnCallRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarginCallResponseIdentification { get; init; }

    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    [IsoId("_7_-OVSqREeyR9JrVGfaMKw")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    [IsoId("_7_-OVyqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Proposal Response Identification")]
    [IsoXmlTag("CollPrpslRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; }

    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_7_-OWSqREeyR9JrVGfaMKw")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral10? SecuritiesCollateral { get; init; }

    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_7_-OWyqREeyR9JrVGfaMKw")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral3? CashCollateral { get; init; }

    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_7_-OXSqREeyR9JrVGfaMKw")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral9? OtherCollateral { get; init; }
}
