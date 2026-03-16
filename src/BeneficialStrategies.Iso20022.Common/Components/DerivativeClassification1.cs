// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hierarchy of classification of a derivative.
/// </summary>
[IsoId("_B4WEgMhtEeadgvwNGwK05w")]
[DisplayName("Derivative Classification")]
public record DerivativeClassification1
{
    /// <summary>
    /// Highest level classification of a derivative.
    /// </summary>
    [IsoId("_ImD5sMhtEeadgvwNGwK05w")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AssetClass { get; init; }

    /// <summary>
    /// Second level classification of a derivative.
    /// </summary>
    [IsoId("_Jb1rIMhtEeadgvwNGwK05w")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BaseProduct { get; init; }

    /// <summary>
    /// Third level classification of a derivative.
    /// </summary>
    [IsoId("_KRGfMMhtEeadgvwNGwK05w")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubProduct { get; init; }

    /// <summary>
    /// Low level classification of commodity derivatives.
    /// </summary>
    [IsoId("_MFkGcMhtEeadgvwNGwK05w")]
    [DisplayName("Sub Commodity")]
    [IsoXmlTag("SubCmmdty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubCommodity { get; init; }

    /// <summary>
    /// Low level classification of a derivative.
    /// </summary>
    [IsoId("_M9Kc0MhtEeadgvwNGwK05w")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionType { get; init; }
}
