// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security pledged as collateral.
/// </summary>
[IsoId("_fMZ5yQAFEeqefbt-QjTNnA")]
[DisplayName("Collateral")]
public record Collateral42
{
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
    /// </summary>
    [IsoId("_fRP9gQAFEeqefbt-QjTNnA")]
    [DisplayName("Collateral Value Date")]
    [IsoXmlTag("CollValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CollateralValueDate { get; init; }

    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_fRP9gwAFEeqefbt-QjTNnA")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public CollateralType16? AssetType { get; init; }

    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_fRP9hQAFEeqefbt-QjTNnA")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; }

    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    [IsoId("_fRP9hwAFEeqefbt-QjTNnA")]
    [DisplayName("Basket Identifier")]
    [IsoXmlTag("BsktIdr")]
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; }
}
