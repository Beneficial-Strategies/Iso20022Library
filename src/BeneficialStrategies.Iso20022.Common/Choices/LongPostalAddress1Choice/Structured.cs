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
namespace BeneficialStrategies.Iso20022.Choices.LongPostalAddress1Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in a formal structure.
    /// </summary>
    [IsoId("_QG4pJ9p-Ed-ak6NoX_4Aeg_-1635487889")]
    [DisplayName("Structured")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Structured : LongPostalAddress1Choice_
    #else
    public partial class Structured : LongPostalAddress1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Structured instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Structured( System.String reqTownName,string reqCountry,System.String reqPostCodeIdentification )
        {
            TownName = reqTownName;
            Country = reqCountry;
            PostCodeIdentification = reqPostCodeIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the building or house.
        /// </summary>
        [IsoId("_QGckRdp-Ed-ak6NoX_4Aeg_1005453911")]
        [DisplayName("Building Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BldgNm")]
        #endif
        [IsoXmlTag("BldgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? BuildingName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BuildingName { get; init; } 
        #else
        public System.String? BuildingName { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a street or thoroughfare.
        /// </summary>
        [IsoId("_QGckRtp-Ed-ak6NoX_4Aeg_1005453819")]
        [DisplayName("Street Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StrtNm")]
        #endif
        [IsoXmlTag("StrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? StreetName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? StreetName { get; init; } 
        #else
        public System.String? StreetName { get; set; } 
        #endif
        
        /// <summary>
        /// Number that identifies the position of a building on a street.
        /// </summary>
        [IsoId("_QGluMNp-Ed-ak6NoX_4Aeg_1005453850")]
        [DisplayName("Street Building Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StrtBldgId")]
        #endif
        [IsoXmlTag("StrtBldgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? StreetBuildingIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? StreetBuildingIdentification { get; init; } 
        #else
        public System.String? StreetBuildingIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Floor or storey within a building.
        /// </summary>
        [IsoId("_QGluMdp-Ed-ak6NoX_4Aeg_1005454212")]
        [DisplayName("Floor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Flr")]
        #endif
        [IsoXmlTag("Flr")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax16Text? Floor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Floor { get; init; } 
        #else
        public System.String? Floor { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government.
        /// </summary>
        [IsoId("_QGluMtp-Ed-ak6NoX_4Aeg_1005453881")]
        [DisplayName("Town Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TwnNm")]
        #endif
        [IsoXmlTag("TwnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text TownName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TownName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TownName { get; init; } 
        #else
        public System.String TownName { get; set; } 
        #endif
        
        /// <summary>
        /// Name of a district, that is, a part of a town or region.
        /// </summary>
        [IsoId("_QGluM9p-Ed-ak6NoX_4Aeg_1005453964")]
        [DisplayName("District Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DstrctNm")]
        #endif
        [IsoXmlTag("DstrctNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DistrictName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DistrictName { get; init; } 
        #else
        public System.String? DistrictName { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of an administrative division of a country, state, or territory.
        /// </summary>
        [IsoId("_QGluNNp-Ed-ak6NoX_4Aeg_1005454644")]
        [DisplayName("Region Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RgnId")]
        #endif
        [IsoXmlTag("RgnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? RegionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegionIdentification { get; init; } 
        #else
        public System.String? RegionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Organised political community or area forming a part of a federation.
        /// </summary>
        [IsoId("_QGluNdp-Ed-ak6NoX_4Aeg_1005454674")]
        [DisplayName("State")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Stat")]
        #endif
        [IsoXmlTag("Stat")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? State { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? State { get; init; } 
        #else
        public System.String? State { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier of a county.
        /// </summary>
        [IsoId("_QGluNtp-Ed-ak6NoX_4Aeg_1005453942")]
        [DisplayName("County Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtyId")]
        #endif
        [IsoXmlTag("CtyId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CountyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CountyIdentification { get; init; } 
        #else
        public System.String? CountyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Nation with its own government.
        /// </summary>
        [IsoId("_QGluN9p-Ed-ak6NoX_4Aeg_1005453697")]
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
        
        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
        /// </summary>
        [IsoId("_QGluONp-Ed-ak6NoX_4Aeg_1005453789")]
        [DisplayName("Post Code Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstCdId")]
        #endif
        [IsoXmlTag("PstCdId")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax16Text PostCodeIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String PostCodeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String PostCodeIdentification { get; init; } 
        #else
        public System.String PostCodeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
        /// </summary>
        [IsoId("_QGluOdp-Ed-ak6NoX_4Aeg_1005454273")]
        [DisplayName("Post Office Box")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="POB")]
        #endif
        [IsoXmlTag("POB")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax16Text? PostOfficeBox { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PostOfficeBox { get; init; } 
        #else
        public System.String? PostOfficeBox { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
