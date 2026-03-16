// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData14Choice
{
    /// <summary>
    /// Data on collateral used for the repurchase trade transaction.
    /// </summary>
    [IsoId("_kyCmMf_9Eemefbt-QjTNnA")]
    [DisplayName("Repurchase Trade")]
    public record RepurchaseTrade : TransactionCollateralData14Choice_
    {
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
        /// </summary>
        [IsoId("_k2Zhwf_9Eemefbt-QjTNnA")]
        [DisplayName("Collateral Value Date")]
        [IsoXmlTag("CollValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? CollateralValueDate { get; init; }

        /// <summary>
        /// Indication of the type of collateral component.
        /// </summary>
        [IsoId("_k2Zhw__9Eemefbt-QjTNnA")]
        [DisplayName("Asset Type")]
        [IsoXmlTag("AsstTp")]
        public CollateralType14? AssetType { get; init; }

        /// <summary>
        /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
        /// </summary>
        [IsoId("_k2Zhxf_9Eemefbt-QjTNnA")]
        [DisplayName("Net Exposure Collateralisation Indicator")]
        [IsoXmlTag("NetXpsrCollstnInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; }

        /// <summary>
        /// Identification of the collateral basket.
        /// </summary>
        [IsoId("_k2Zhx__9Eemefbt-QjTNnA")]
        [DisplayName("Basket Identifier")]
        [IsoXmlTag("BsktIdr")]
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; }
    }
}
