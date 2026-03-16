// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information about mergers.
/// </summary>
[IsoId("_IY-XYFPaEeG1qPPaW9KJvg")]
[DisplayName("Merger Details Type")]
public record MergerDetailsType1
{
    /// <summary>
    /// Differentiation of different types of merger.
    /// 合併/株式交換/株式移転の区分.
    /// </summary>
    [IsoId("_eG0j4FPaEeG1qPPaW9KJvg")]
    [DisplayName("Merger Type")]
    [IsoXmlTag("MrgrTp")]
    public MergerTypeCode? MergerType { get; init; }

    /// <summary>
    /// Information about the counterparty in case of [sankaku] gappei: the scenario where a third party is involved as one of the counterparties in the merger but there is no security movement from the third party.
    /// </summary>
    [IsoId("_DPO70GHPEeGknP6xAc4fKw")]
    [DisplayName("Counterparty Details")]
    [IsoXmlTag("CtrPtyDtls")]
    public CounterpartyDetailsType1? CounterpartyDetails { get; init; }

    /// <summary>
    /// Classification of the simplified merger regulatory condition of the parent company.
    /// 簡易区分.
    /// </summary>
    [IsoId("_tJIsgFPaEeG1qPPaW9KJvg")]
    [DisplayName("Simplified Merger Classification")]
    [IsoXmlTag("SmplfdMrgrClssfctn")]
    public MergerCode? SimplifiedMergerClassification { get; init; }

    /// <summary>
    /// Classification of the short form merger regulatory condition of the subsidiary company.
    /// 略式区分.
    /// </summary>
    [IsoId("_WIGg9WzgEeGa9q9Mq4E7uA")]
    [DisplayName("Short Form Merger Classification")]
    [IsoXmlTag("ShrtFormMrgrClssfctn")]
    public MergerCode? ShortFormMergerClassification { get; init; }

    /// <summary>
    /// Share unit quantity of the shares of the new company.
    /// 新設会社の単元株数.
    /// </summary>
    [IsoId("_2NisQFPaEeG1qPPaW9KJvg")]
    [DisplayName("Share Unit Quantity Of New Company")]
    [IsoXmlTag("ShrUnitQtyOfNewCpny")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ShareUnitQuantityOfNewCompany { get; init; }
}
