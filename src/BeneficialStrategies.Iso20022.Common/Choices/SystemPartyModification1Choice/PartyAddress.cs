// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_ko4Ls-5NEeCisYr99QEiWA_-537539233")]
    [DisplayName("Party Address")]
    public partial record PartyAddress : SystemPartyModification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        [IsoId("_km8SAO5NEeCisYr99QEiWA_855284979")]
        [DisplayName("Street Name")]
        [IsoXmlTag("StrtNm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public IsoMax70Text? StreetName { get; init; } 
        
        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        [IsoId("_km8SAe5NEeCisYr99QEiWA_1616050132")]
        [DisplayName("Building Number")]
        [IsoXmlTag("BldgNb")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? BuildingNumber { get; init; } 
        
        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        [IsoId("_km8SAu5NEeCisYr99QEiWA_-393906726")]
        [DisplayName("Post Code")]
        [IsoXmlTag("PstCd")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public IsoMax16Text? PostCode { get; init; } 
        
        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.|.
        /// </summary>
        [IsoId("_km8SA-5NEeCisYr99QEiWA_-1197741420")]
        [DisplayName("Town Name")]
        [IsoXmlTag("TwnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TownName { get; init; } 
        
        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county.
        /// </summary>
        [IsoId("_km8SBO5NEeCisYr99QEiWA_-743654151")]
        [DisplayName("Country Sub Division")]
        [IsoXmlTag("CtrySubDvsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CountrySubDivision { get; init; } 
        
        /// <summary>
        /// Nation with its own government.
        /// </summary>
        [IsoId("_knFb8O5NEeCisYr99QEiWA_1866473794")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public CountryCode? Country { get; init; } 
        
        /// <summary>
        /// Starting date from which the address is valid.
        /// </summary>
        [IsoId("_knFb8e5NEeCisYr99QEiWA_-753427361")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValidFrom { get; init; } 
        
        
        #nullable disable
        
    }
}
