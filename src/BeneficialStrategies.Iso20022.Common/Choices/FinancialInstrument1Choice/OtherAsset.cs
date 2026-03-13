// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument1Choice
{
    /// <summary>
    /// Identification of another kind of asset in the holding that is not a security or cash.
    /// </summary>
    [IsoId("_xW6fEEyGEeir2sRRVd9XhA")]
    [DisplayName("Other Asset")]
    public partial record OtherAsset : FinancialInstrument1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of asset.
        /// </summary>
        [IsoId("_8oUagEyJEeir2sRRVd9XhA")]
        [DisplayName("Other Asset Type")]
        [IsoXmlTag("OthrAsstTp")]
        public required OtherAsset1Choice_ OtherAssetType { get; init; } 
        
        /// <summary>
        /// Technical identification of the asset.
        /// </summary>
        [IsoId("_F_4m0EyKEeir2sRRVd9XhA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Name of the asset.
        /// </summary>
        [IsoId("_IkIFMEyKEeir2sRRVd9XhA")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Name { get; init; } 
        
        /// <summary>
        /// Addition identification of the asset.
        /// </summary>
        [IsoId("_Ly68cEyKEeir2sRRVd9XhA")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> OtherIdentification { get; init; } = [];
        
        /// <summary>
        /// Additional information about the other asset.
        /// </summary>
        [IsoId("_OAtCoEyKEeir2sRRVd9XhA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
