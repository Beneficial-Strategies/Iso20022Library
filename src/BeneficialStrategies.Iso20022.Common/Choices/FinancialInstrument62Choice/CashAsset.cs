// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument62Choice
{
    /// <summary>
    /// Identification of the cash asset.
    /// </summary>
    [IsoId("_qD51c5y1Eem54rMzia0iag")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument62Choice_
    {
        /// <summary>
        /// Type of cash asset.
        /// </summary>
        [IsoId("_wLLccZNDEemQB_8XA98K0Q")]
        [DisplayName("Cash Asset Type")]
        [IsoXmlTag("CshAsstTp")]
        public required CashAssetType1Choice_ CashAssetType { get; init; }

        /// <summary>
        /// Currency of the asset in the holding.
        /// </summary>
        [IsoId("_PdRmYJNEEemQB_8XA98K0Q")]
        [DisplayName("Holding Currency")]
        [IsoXmlTag("HldgCcy")]
        public required ActiveCurrencyCode HoldingCurrency { get; init; }

        /// <summary>
        /// Additional information about the cash asset.
        /// </summary>
        [IsoId("_wLLcc5NDEemQB_8XA98K0Q")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
