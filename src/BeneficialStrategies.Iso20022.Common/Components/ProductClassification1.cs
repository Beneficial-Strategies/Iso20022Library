// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0 (https://www.isda.org/2018/02/20/final-isda-taxonomy-v1-0-and-final-isda-taxonomy-v2-0/).
/// </summary>
[IsoId("_M00DgDXHEemdWfjs3tykFQ")]
[DisplayName("Product Classification")]
public record ProductClassification1
{
    /// <summary>
    /// Asset class of the underlying of the derivative (e.g. Interest Rate, Commodity, Equity).
    /// </summary>
    [IsoId("_WPDJUDXHEemdWfjs3tykFQ")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AssetClass { get; init; }

    /// <summary>
    /// Market of the underlying product (IR Swap, Freight, Precious/Non Precious).
    /// </summary>
    [IsoId("_YzAT0DXHEemdWfjs3tykFQ")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BaseProduct { get; init; }

    /// <summary>
    /// Further details of the product type.
    /// </summary>
    [IsoId("_bSfOADXHEemdWfjs3tykFQ")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubProduct { get; init; }

    /// <summary>
    /// Further details if the asset class is commodity.
    /// </summary>
    [IsoId("_d65asDXHEemdWfjs3tykFQ")]
    [DisplayName("Sub Commodity")]
    [IsoXmlTag("SubCmmdty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubCommodity { get; init; }

    /// <summary>
    /// Type of the transaction, for example, option, spot forward or exotic.
    /// </summary>
    [IsoId("_gLqjcDXHEemdWfjs3tykFQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionType { get; init; }
}
