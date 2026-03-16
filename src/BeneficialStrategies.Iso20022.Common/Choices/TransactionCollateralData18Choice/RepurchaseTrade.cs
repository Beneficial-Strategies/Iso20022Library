// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData18Choice
{
    /// <summary>
    /// Data on collateral used for the repurchase trade transaction.
    /// </summary>
    [IsoId("_C6xiscg5Eeu4ecZgAYuz5w")]
    [DisplayName("Repurchase Trade")]
    public record RepurchaseTrade : TransactionCollateralData18Choice_
    {
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
        /// </summary>
        [IsoId("_C8NGE8g5Eeu4ecZgAYuz5w")]
        [DisplayName("Collateral Value Date")]
        [IsoXmlTag("CollValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? CollateralValueDate { get; init; }

        /// <summary>
        /// Indication of the type of collateral component.
        /// </summary>
        [IsoId("_C8NGFcg5Eeu4ecZgAYuz5w")]
        [DisplayName("Asset Type")]
        [IsoXmlTag("AsstTp")]
        public CollateralType21? AssetType { get; init; }

        /// <summary>
        /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
        /// </summary>
        [IsoId("_C8NGF8g5Eeu4ecZgAYuz5w")]
        [DisplayName("Net Exposure Collateralisation Indicator")]
        [IsoXmlTag("NetXpsrCollstnInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; }

        /// <summary>
        /// Identification of the collateral basket.
        /// </summary>
        [IsoId("_C8NGGcg5Eeu4ecZgAYuz5w")]
        [DisplayName("Basket Identifier")]
        [IsoXmlTag("BsktIdr")]
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; }
    }
}
