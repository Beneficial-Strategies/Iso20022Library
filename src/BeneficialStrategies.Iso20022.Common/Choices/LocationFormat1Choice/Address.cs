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
namespace BeneficialStrategies.Iso20022.Choices.LocationFormat1Choice
{
    /// <summary>
    /// Specifies physical address of the meeting.
    /// </summary>
    [IsoId("_RXD3mNp-Ed-ak6NoX_4Aeg_-217471735")]
    [DisplayName("Address")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Address : LocationFormat1Choice_
    #else
    public partial class Address : LocationFormat1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Address instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Address( string reqCountry )
        {
            Country = reqCountry;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the nature of the postal address.
        /// </summary>
        [IsoId("_QG4pKdp-Ed-ak6NoX_4Aeg_-293371907")]
        [DisplayName("Address Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AdrTp")]
        #endif
        [IsoXmlTag("AdrTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AddressType2Code? AddressType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AddressType2Code? AddressType { get; init; } 
        #else
        public AddressType2Code? AddressType { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
        /// </summary>
        [IsoId("_QG4pKtp-Ed-ak6NoX_4Aeg_-484540115")]
        [DisplayName("Address Line")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AdrLine")]
        #endif
        [IsoXmlTag("AdrLine")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public SimpleValueList<System.String> AddressLine { get; init; } = new SimpleValueList<System.String>(){};
        
        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        [IsoId("_QG4pK9p-Ed-ak6NoX_4Aeg_-1702876782")]
        [DisplayName("Street Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StrtNm")]
        #endif
        [IsoXmlTag("StrtNm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax70Text? StreetName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? StreetName { get; init; } 
        #else
        public System.String? StreetName { get; set; } 
        #endif
        
        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        [IsoId("_QG4pLNp-Ed-ak6NoX_4Aeg_-1628995660")]
        [DisplayName("Building Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BldgNb")]
        #endif
        [IsoXmlTag("BldgNb")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax16Text? BuildingNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BuildingNumber { get; init; } 
        #else
        public System.String? BuildingNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        [IsoId("_QHCaINp-Ed-ak6NoX_4Aeg_-14467862")]
        [DisplayName("Post Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstCd")]
        #endif
        [IsoXmlTag("PstCd")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax16Text? PostCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PostCode { get; init; } 
        #else
        public System.String? PostCode { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        [IsoId("_QHCaIdp-Ed-ak6NoX_4Aeg_15083256")]
        [DisplayName("Town Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TwnNm")]
        #endif
        [IsoXmlTag("TwnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TownName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TownName { get; init; } 
        #else
        public System.String? TownName { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies a subdivision of a country for example, state, region, county.
        /// </summary>
        [IsoId("_QHCaItp-Ed-ak6NoX_4Aeg_44636499")]
        [DisplayName("Country Sub Division")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrySubDvsn")]
        #endif
        [IsoXmlTag("CtrySubDvsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CountrySubDivision { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CountrySubDivision { get; init; } 
        #else
        public System.String? CountrySubDivision { get; set; } 
        #endif
        
        /// <summary>
        /// Nation with its own government.
        /// </summary>
        [IsoId("_QHCaI9p-Ed-ak6NoX_4Aeg_-34786848")]
        [DisplayName("Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ctry")]
        #endif
        [IsoXmlTag("Ctry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountryCode Country { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string Country { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Country { get; init; } 
        #else
        public string Country { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
