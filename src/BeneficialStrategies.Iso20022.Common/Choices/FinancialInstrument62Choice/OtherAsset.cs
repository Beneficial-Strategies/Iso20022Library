// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument62Choice
{
    /// <summary>
    /// Identification of another kind of asset in the holding that is not a security or cash.
    /// </summary>
    [IsoId("_qD51dZy1Eem54rMzia0iag")]
    [DisplayName("Other Asset")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherAsset : FinancialInstrument62Choice_
    #else
    public partial class OtherAsset : FinancialInstrument62Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherAsset instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherAsset( OtherAsset2Choice_ reqOtherAssetType,System.String reqIdentification )
        {
            OtherAssetType = reqOtherAssetType;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of asset.
        /// </summary>
        [IsoId("_mrKwsZNBEemQB_8XA98K0Q")]
        [DisplayName("Other Asset Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrAsstTp")]
        #endif
        [IsoXmlTag("OthrAsstTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OtherAsset2Choice_ OtherAssetType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OtherAsset2Choice_ OtherAssetType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherAsset2Choice_ OtherAssetType { get; init; } 
        #else
        public OtherAsset2Choice_ OtherAssetType { get; set; } 
        #endif
        
        /// <summary>
        /// Technical identification of the asset.
        /// </summary>
        [IsoId("_mrKws5NBEemQB_8XA98K0Q")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the asset.
        /// </summary>
        [IsoId("_mrKwtZNBEemQB_8XA98K0Q")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Description of the asset.
        /// </summary>
        [IsoId("_syYKoP8dEemiJ7i9El0LvQ")]
        [DisplayName("Description")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Desc")]
        #endif
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Description { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Description { get; init; } 
        #else
        public System.String? Description { get; set; } 
        #endif
        
        /// <summary>
        /// Additional identification of the asset.
        /// </summary>
        [IsoId("_mrKwt5NBEemQB_8XA98K0Q")]
        [DisplayName("Other Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrId")]
        #endif
        [IsoXmlTag("OthrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> OtherIdentification { get; init; } = new SimpleValueList<System.String>(){};
        
        /// <summary>
        /// Additional information about the other asset.
        /// </summary>
        [IsoId("_mrKwuZNBEemQB_8XA98K0Q")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #else
        public AdditionalInformation15? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
