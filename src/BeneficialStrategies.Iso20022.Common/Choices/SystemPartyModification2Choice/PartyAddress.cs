// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_yJhSqYv-Eei289CGNqs21g")]
    [DisplayName("Party Address")]
    public partial record PartyAddress : SystemPartyModification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the nature of the postal address.
        /// </summary>
        [IsoId("__Coc4RisEeiNm9ItaZcR2A")]
        [DisplayName("Address Type")]
        [IsoXmlTag("AdrTp")]
        public AddressType3Choice_? AddressType { get; init; } 
        
        /// <summary>
        /// Identification of a division of a large organisation or building.
        /// </summary>
        [IsoId("_qBGoyYv4Eei289CGNqs21g")]
        [DisplayName("Department")]
        [IsoXmlTag("Dept")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? Department { get; init; } 
        
        /// <summary>
        /// Identification of a sub-division of a large organisation or building.
        /// </summary>
        [IsoId("_qBGoyov4Eei289CGNqs21g")]
        [DisplayName("Sub Department")]
        [IsoXmlTag("SubDept")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? SubDepartment { get; init; } 
        
        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        [IsoId("__Coc5RisEeiNm9ItaZcR2A")]
        [DisplayName("Street Name")]
        [IsoXmlTag("StrtNm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? StreetName { get; init; } 
        
        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        [IsoId("__Coc5xisEeiNm9ItaZcR2A")]
        [DisplayName("Building Number")]
        [IsoXmlTag("BldgNb")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? BuildingNumber { get; init; } 
        
        /// <summary>
        /// Name of the building or house.
        /// </summary>
        [IsoId("_qBGoy4v4Eei289CGNqs21g")]
        [DisplayName("Building Name")]
        [IsoXmlTag("BldgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? BuildingName { get; init; } 
        
        /// <summary>
        /// Floor or storey within a building.
        /// </summary>
        [IsoId("_qBGozIv4Eei289CGNqs21g")]
        [DisplayName("Floor")]
        [IsoXmlTag("Flr")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? Floor { get; init; } 
        
        /// <summary>
        /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
        /// </summary>
        [IsoId("_qBGozYv4Eei289CGNqs21g")]
        [DisplayName("Post Box")]
        [IsoXmlTag("PstBx")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? PostBox { get; init; } 
        
        /// <summary>
        /// Building room number.
        /// </summary>
        [IsoId("_qBGozov4Eei289CGNqs21g")]
        [DisplayName("Room")]
        [IsoXmlTag("Room")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? Room { get; init; } 
        
        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        [IsoId("__Coc6RisEeiNm9ItaZcR2A")]
        [DisplayName("Post Code")]
        [IsoXmlTag("PstCd")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? PostCode { get; init; } 
        
        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        [IsoId("__Coc6xisEeiNm9ItaZcR2A")]
        [DisplayName("Town Name")]
        [IsoXmlTag("TwnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TownName { get; init; } 
        
        /// <summary>
        /// Specific location name within the town.
        /// </summary>
        [IsoId("_qBGoz4v4Eei289CGNqs21g")]
        [DisplayName("Town Location Name")]
        [IsoXmlTag("TwnLctnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TownLocationName { get; init; } 
        
        /// <summary>
        /// Identifies a subdivision within a country sub-division.
        /// </summary>
        [IsoId("_qBGo0Iv4Eei289CGNqs21g")]
        [DisplayName("District Name")]
        [IsoXmlTag("DstrctNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DistrictName { get; init; } 
        
        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county.
        /// </summary>
        [IsoId("__Coc7RisEeiNm9ItaZcR2A")]
        [DisplayName("Country Sub Division")]
        [IsoXmlTag("CtrySubDvsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CountrySubDivision { get; init; } 
        
        /// <summary>
        /// Nation with its own government.
        /// </summary>
        [IsoId("__Coc7xisEeiNm9ItaZcR2A")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public CountryCode? Country { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
        /// </summary>
        [IsoId("_qBGo0Yv4Eei289CGNqs21g")]
        [DisplayName("Address Line")]
        [IsoXmlTag("AdrLine")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [MinLength(0)]
        [MaxLength(7)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public SimpleValueList<System.String> AddressLine { get; init; } = [];
        
        /// <summary>
        /// Specifies the date from which the address is valid.
        /// </summary>
        [IsoId("_DcD7QBitEeiNm9ItaZcR2A")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValidFrom { get; init; } 
        
        
        #nullable disable
        
    }
}
