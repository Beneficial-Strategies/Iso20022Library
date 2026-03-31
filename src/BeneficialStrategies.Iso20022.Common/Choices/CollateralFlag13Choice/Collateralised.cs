// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag13Choice
{
    /// <summary>
    /// Specifies the details of the collateralised securities.
    /// </summary>
    [IsoId("_J_aqIcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Collateralised")]
    [IsoXmlTag("Collsd")]
    public record Collateralised : CollateralFlag13Choice_
    {
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the securities financing transaction.
        /// </summary>
        [IsoId("_KA3bo8g5Eeu4ecZgAYuz5w")]
        [DisplayName("Collateral Value Date")]
        [IsoXmlTag("CollValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? CollateralValueDate { get; init; }

        /// <summary>
        /// Specification on the type of asset used as collateral.
        /// </summary>
        [IsoId("_KA3bpcg5Eeu4ecZgAYuz5w")]
        [DisplayName("Asset Type")]
        [IsoXmlTag("AsstTp")]
        public CollateralType21? AssetType { get; init; }

        /// <summary>
        /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
        /// </summary>
        [IsoId("_KA3bp8g5Eeu4ecZgAYuz5w")]
        [DisplayName("Net Exposure Collateralisation Indicator")]
        [IsoXmlTag("NetXpsrCollstnInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; }

        /// <summary>
        /// Identification of the collateral basket.
        /// </summary>
        [IsoId("_KA3bqcg5Eeu4ecZgAYuz5w")]
        [DisplayName("Basket Identifier")]
        [IsoXmlTag("BsktIdr")]
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; }
    }
}
