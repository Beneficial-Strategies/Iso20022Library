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
namespace BeneficialStrategies.Iso20022.Choices.Party32Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_wTngcUNMEeamLdeYEZm56w")]
    [DisplayName("Organisation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Organisation : Party32Choice_
    #else
    public partial class Organisation : Party32Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which the organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_wsxAQUNMEeamLdeYEZm56w")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_wsxAQ0NMEeamLdeYEZm56w")]
        [DisplayName("Short Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtNm")]
        #endif
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ShortName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ShortName { get; init; } 
        #else
        public System.String? ShortName { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for the organisation.
        /// </summary>
        [IsoId("_wsxARUNMEeamLdeYEZm56w")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification72Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification72Choice_? Identification { get; init; } 
        #else
        public PartyIdentification72Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_wsxAR0NMEeamLdeYEZm56w")]
        [DisplayName("Legal Entity Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LglNttyIdr")]
        #endif
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LegalEntityIdentifier { get; init; } 
        #else
        public System.String? LegalEntityIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_wsxASUNMEeamLdeYEZm56w")]
        [DisplayName("Purpose")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Purp")]
        #endif
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Purpose { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Purpose { get; init; } 
        #else
        public System.String? Purpose { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_wsxAS0NMEeamLdeYEZm56w")]
        [DisplayName("Registration Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnCtry")]
        #endif
        [IsoXmlTag("RegnCtry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? RegistrationCountry { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? RegistrationCountry { get; init; } 
        #else
        public string? RegistrationCountry { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_wsxATUNMEeamLdeYEZm56w")]
        [DisplayName("Registration Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnDt")]
        #endif
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? RegistrationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? RegistrationDate { get; init; } 
        #else
        public System.DateOnly? RegistrationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_wsxAT0NMEeamLdeYEZm56w")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<PostalAddress21> PostalAddress { get; init; } = new ValueList<PostalAddress21>(){};
        
        /// <summary>
        /// Type of organisation.
        /// </summary>
        [IsoId("_wsxAUUNMEeamLdeYEZm56w")]
        [DisplayName("Type Of Organisation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TpOfOrg")]
        #endif
        [IsoXmlTag("TpOfOrg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
        #else
        public OrganisationType1Choice_? TypeOfOrganisation { get; set; } 
        #endif
        
        /// <summary>
        /// Place of listing for shares in the organisation.
        /// </summary>
        [IsoId("_JPkAcUzsEea8fovz_9xSTQ")]
        [DisplayName("Place Of Listing")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PlcOfListg")]
        #endif
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMICIdentifier? PlaceOfListing { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PlaceOfListing { get; init; } 
        #else
        public System.String? PlaceOfListing { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
