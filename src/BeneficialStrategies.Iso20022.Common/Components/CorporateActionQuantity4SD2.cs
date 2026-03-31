// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify corporate action quantities.
/// </summary>
[IsoId("_o9JB5GCXEeK8P92abE6HIA")]
[DisplayName("Corporate Action Quantity 4 SD")]
public record CorporateActionQuantity4SD2
{
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_o9JB9WCXEeK8P92abE6HIA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Planned number of shares to be purchased.
    ///  買付予定株式数.
    /// </summary>
    [IsoId("_o9JCBmCXEeK8P92abE6HIA")]
    [DisplayName("Planned Quantity")]
    [IsoXmlTag("PlandQty")]
    public PlannedQuantity1Choice_? PlannedQuantity { get; init; }

    /// <summary>
    /// Planned excess quantity of share purchase.
    /// 買付超過予定数
    /// </summary>
    [IsoId("_o9JCCWCXEeK8P92abE6HIA")]
    [DisplayName("Planned Excess Purchase Quantity")]
    [IsoXmlTag("PlandXcssPurchsQty")]
    public PlannedQuantity1Choice_? PlannedExcessPurchaseQuantity { get; init; }

    /// <summary>
    /// TSE/JASDEC code for the minimum number of shares to be purchased when the corporate action event type code is TEND or BIDS.
    /// 買付株数に係る下限設定が「下限設定あり」「未定」.
    /// </summary>
    [IsoId("_o9JCA2CXEeK8P92abE6HIA")]
    [DisplayName("Minimum Quantity Code")]
    [IsoXmlTag("MinQtyCd")]
    public SecuritiesQuantity1Code? MinimumQuantityCode { get; init; }

    /// <summary>
    /// TSE/JASDEC code for the maximum number of shares to be purchased when the corporate action event type code is TEND or BIDS.
    ///  買付株数に係る上限設定が「上限設定あり」「未定」.
    /// </summary>
    [IsoId("_o9JB-GCXEeK8P92abE6HIA")]
    [DisplayName("Maximum Quantity Code")]
    [IsoXmlTag("MaxQtyCd")]
    public SecuritiesQuantity1Code? MaximumQuantityCode { get; init; }

    /// <summary>
    /// Old share unit quantity.
    /// </summary>
    [IsoId("_o9JB72CXEeK8P92abE6HIA")]
    [DisplayName("Old Share Unit Quantity")]
    [IsoXmlTag("OdShrUnitQty")]
    public FinancialInstrumentQuantity15Choice_? OldShareUnitQuantity { get; init; }

    /// <summary>
    /// New share unit quantity.
    /// </summary>
    [IsoId("_o9JB6mCXEeK8P92abE6HIA")]
    [DisplayName("New Share Unit Quantity")]
    [IsoXmlTag("NewShrUnitQty")]
    public FinancialInstrumentQuantity15Choice_? NewShareUnitQuantity { get; init; }
}
