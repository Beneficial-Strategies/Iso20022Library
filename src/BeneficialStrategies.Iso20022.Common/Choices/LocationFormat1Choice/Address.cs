// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LocationFormat1Choice
{
    /// <summary>
    /// Specifies physical address of the meeting.
    /// </summary>
    [IsoId("_RXD3mNp-Ed-ak6NoX_4Aeg_-217471735")]
    [DisplayName("Address")]
    public partial record Address : LocationFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the nature of the postal address.
        /// </summary>
        [IsoId("_QG4pKdp-Ed-ak6NoX_4Aeg_-293371907")]
        [DisplayName("Address Type")]
        [IsoXmlTag("AdrTp")]
        public AddressType2Code? AddressType { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
        /// </summary>
        [IsoId("_QG4pKtp-Ed-ak6NoX_4Aeg_-484540115")]
        [DisplayName("Address Line")]
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
        [IsoXmlTag("StrtNm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? StreetName { get; init; } 
        
        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        [IsoId("_QG4pLNp-Ed-ak6NoX_4Aeg_-1628995660")]
        [DisplayName("Building Number")]
        [IsoXmlTag("BldgNb")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? BuildingNumber { get; init; } 
        
        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        [IsoId("_QHCaINp-Ed-ak6NoX_4Aeg_-14467862")]
        [DisplayName("Post Code")]
        [IsoXmlTag("PstCd")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? PostCode { get; init; } 
        
        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        [IsoId("_QHCaIdp-Ed-ak6NoX_4Aeg_15083256")]
        [DisplayName("Town Name")]
        [IsoXmlTag("TwnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TownName { get; init; } 
        
        /// <summary>
        /// Identifies a subdivision of a country for example, state, region, county.
        /// </summary>
        [IsoId("_QHCaItp-Ed-ak6NoX_4Aeg_44636499")]
        [DisplayName("Country Sub Division")]
        [IsoXmlTag("CtrySubDvsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CountrySubDivision { get; init; } 
        
        /// <summary>
        /// Nation with its own government.
        /// </summary>
        [IsoId("_QHCaI9p-Ed-ak6NoX_4Aeg_-34786848")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public required CountryCode Country { get; init; } 
        
        
        #nullable disable
        
    }
}
