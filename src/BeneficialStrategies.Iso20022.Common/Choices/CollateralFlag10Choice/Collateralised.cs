// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag10Choice
{
    /// <summary>
    /// Data on collateralised securities.
    /// </summary>
    [IsoId("_gI37UQAAEeqefbt-QjTNnA")]
    [DisplayName("Collateralised")]
    [IsoXmlTag("Collsd")]
    public record Collateralised : CollateralFlag10Choice_
    {
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the securities financing transaction.
        /// </summary>
        [IsoId("_gOOVYQAAEeqefbt-QjTNnA")]
        [DisplayName("Collateral Value Date")]
        [IsoXmlTag("CollValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? CollateralValueDate { get; init; }

        /// <summary>
        /// Specification on the type of asset used as collateral.
        /// </summary>
        [IsoId("_gOOVYwAAEeqefbt-QjTNnA")]
        [DisplayName("Asset Type")]
        [IsoXmlTag("AsstTp")]
        public CollateralType14? AssetType { get; init; }

        /// <summary>
        /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
        /// </summary>
        [IsoId("_gOOVZQAAEeqefbt-QjTNnA")]
        [DisplayName("Net Exposure Collateralisation Indicator")]
        [IsoXmlTag("NetXpsrCollstnInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; }

        /// <summary>
        /// Identification of the collateral basket.
        /// </summary>
        [IsoId("_gOOVZwAAEeqefbt-QjTNnA")]
        [DisplayName("Basket Identifier")]
        [IsoXmlTag("BsktIdr")]
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; }
    }
}
