// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument1Choice
{
    /// <summary>
    /// Identification of the cash asset.
    /// </summary>
    [IsoId("_vbukwEyGEeir2sRRVd9XhA")]
    [DisplayName("Cash Asset")]
    public record CashAsset : FinancialInstrument1Choice_
    {
        /// <summary>
        /// Type of cash asset.
        /// </summary>
        [IsoId("_VrtRYEyIEeir2sRRVd9XhA")]
        [DisplayName("Cash Asset Type")]
        [IsoXmlTag("CshAsstTp")]
        public required CashAssetType1Choice_ CashAssetType { get; init; }

        /// <summary>
        /// Additional information about the cash asset.
        /// </summary>
        [IsoId("_cMk9YEyIEeir2sRRVd9XhA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
