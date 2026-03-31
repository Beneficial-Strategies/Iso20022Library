// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument62Choice
{
    /// <summary>
    /// Identification of another kind of asset in the holding that is not a security or cash.
    /// </summary>
    [IsoId("_qD51dZy1Eem54rMzia0iag")]
    [DisplayName("Other Asset")]
    [IsoXmlTag("OthrAsst")]
    public record OtherAsset : FinancialInstrument62Choice_
    {
        /// <summary>
        /// Type of asset.
        /// </summary>
        [IsoId("_mrKwsZNBEemQB_8XA98K0Q")]
        [DisplayName("Other Asset Type")]
        [IsoXmlTag("OthrAsstTp")]
        public required OtherAsset2Choice_ OtherAssetType { get; init; }

        /// <summary>
        /// Technical identification of the asset.
        /// </summary>
        [IsoId("_mrKws5NBEemQB_8XA98K0Q")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Name of the asset.
        /// </summary>
        [IsoId("_mrKwtZNBEemQB_8XA98K0Q")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Name { get; init; }

        /// <summary>
        /// Description of the asset.
        /// </summary>
        [IsoId("_syYKoP8dEemiJ7i9El0LvQ")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Description { get; init; }

        /// <summary>
        /// Additional identification of the asset.
        /// </summary>
        [IsoId("_mrKwt5NBEemQB_8XA98K0Q")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public SimpleValueList<System.String> OtherIdentification { get; init; } = [];

        /// <summary>
        /// Additional information about the other asset.
        /// </summary>
        [IsoId("_mrKwuZNBEemQB_8XA98K0Q")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
