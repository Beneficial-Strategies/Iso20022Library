// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument63Choice
{
    /// <summary>
    /// Identification of the cash asset.
    /// </summary>
    [IsoId("_nj5gM6PvEemf4IaGqCtquA")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument63Choice_
    {
        /// <summary>
        /// Type of cash asset.
        /// </summary>
        [IsoId("_UKrowaPvEemf4IaGqCtquA")]
        [DisplayName("Cash Asset Type")]
        [IsoXmlTag("CshAsstTp")]
        public required CashAssetType1Choice_ CashAssetType { get; init; }

        /// <summary>
        /// Currency of the asset in the holding.
        /// </summary>
        [IsoId("_UKrow6PvEemf4IaGqCtquA")]
        [DisplayName("Holding Currency")]
        [IsoXmlTag("HldgCcy")]
        public required ActiveCurrencyCode HoldingCurrency { get; init; }

        /// <summary>
        /// Currency of the asset in another currency.
        /// </summary>
        [IsoId("_UKroxaPvEemf4IaGqCtquA")]
        [DisplayName("Transfer Currency")]
        [IsoXmlTag("TrfCcy")]
        public ActiveCurrencyCode? TransferCurrency { get; init; }

        /// <summary>
        /// Additional information about the cash asset.
        /// </summary>
        [IsoId("_UKrox6PvEemf4IaGqCtquA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
