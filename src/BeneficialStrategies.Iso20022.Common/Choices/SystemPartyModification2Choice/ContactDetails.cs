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
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies the options on how to contact the party.
    /// </summary>
    [IsoId("_J8b4wYwAEei289CGNqs21g")]
    [DisplayName("Contact Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ContactDetails : SystemPartyModification2Choice_
    #else
    public partial class ContactDetails : SystemPartyModification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoId("_rJkiI4v3Eei289CGNqs21g")]
        [DisplayName("Name Prefix")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmPrfx")]
        #endif
        [IsoXmlTag("NmPrfx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NamePrefix2Code? NamePrefix { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NamePrefix2Code? NamePrefix { get; init; } 
        #else
        public NamePrefix2Code? NamePrefix { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_rJkiJYv3Eei289CGNqs21g")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Collection of information that identifies a phone number, as defined by telecom services.
        /// </summary>
        [IsoId("_rJkiJ4v3Eei289CGNqs21g")]
        [DisplayName("Phone Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PhneNb")]
        #endif
        [IsoXmlTag("PhneNb")]
        [IsoSimpleType(IsoSimpleType.PhoneNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPhoneNumber? PhoneNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PhoneNumber { get; init; } 
        #else
        public System.String? PhoneNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Collection of information that identifies a mobile phone number, as defined by telecom services.
        /// </summary>
        [IsoId("_rJkiKYv3Eei289CGNqs21g")]
        [DisplayName("Mobile Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MobNb")]
        #endif
        [IsoXmlTag("MobNb")]
        [IsoSimpleType(IsoSimpleType.PhoneNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPhoneNumber? MobileNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MobileNumber { get; init; } 
        #else
        public System.String? MobileNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Collection of information that identifies a FAX number, as defined by telecom services.
        /// </summary>
        [IsoId("_rJkiK4v3Eei289CGNqs21g")]
        [DisplayName("Fax Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FaxNb")]
        #endif
        [IsoXmlTag("FaxNb")]
        [IsoSimpleType(IsoSimpleType.PhoneNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPhoneNumber? FaxNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? FaxNumber { get; init; } 
        #else
        public System.String? FaxNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_rJkiLYv3Eei289CGNqs21g")]
        [DisplayName("Email Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EmailAdr")]
        #endif
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max2048Text)]
        [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax2048Text? EmailAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailAddress { get; init; } 
        #else
        public System.String? EmailAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose for which an email address may be used.
        /// </summary>
        [IsoId("_rJlJMYv3Eei289CGNqs21g")]
        [DisplayName("Email Purpose")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EmailPurp")]
        #endif
        [IsoXmlTag("EmailPurp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? EmailPurpose { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailPurpose { get; init; } 
        #else
        public System.String? EmailPurpose { get; set; } 
        #endif
        
        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_rJlJM4v3Eei289CGNqs21g")]
        [DisplayName("Job Title")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="JobTitl")]
        #endif
        [IsoXmlTag("JobTitl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? JobTitle { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? JobTitle { get; init; } 
        #else
        public System.String? JobTitle { get; set; } 
        #endif
        
        /// <summary>
        /// Role of a person in an organisation.
        /// </summary>
        [IsoId("_rJlJNYv3Eei289CGNqs21g")]
        [DisplayName("Responsibility")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rspnsblty")]
        #endif
        [IsoXmlTag("Rspnsblty")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Responsibility { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Responsibility { get; init; } 
        #else
        public System.String? Responsibility { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of a division of a large organisation or building.
        /// </summary>
        [IsoId("_rJlJN4v3Eei289CGNqs21g")]
        [DisplayName("Department")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dept")]
        #endif
        [IsoXmlTag("Dept")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax70Text? Department { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Department { get; init; } 
        #else
        public System.String? Department { get; set; } 
        #endif
        
        /// <summary>
        /// Contact details in another form.
        /// </summary>
        [IsoId("_rJlJOYv3Eei289CGNqs21g")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherContact1? Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherContact1? Other { get; init; } 
        #else
        public OtherContact1? Other { get; set; } 
        #endif
        
        /// <summary>
        /// Preferred method used to reach the technical contact.
        /// </summary>
        [IsoId("_rJlJO4v3Eei289CGNqs21g")]
        [DisplayName("Preferred Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrefrdMtd")]
        #endif
        [IsoXmlTag("PrefrdMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PreferredContactMethod1Code? PreferredMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PreferredContactMethod1Code? PreferredMethod { get; init; } 
        #else
        public PreferredContactMethod1Code? PreferredMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Starting validity date for the contact.
        /// </summary>
        [IsoId("_vDRXkov3Eei289CGNqs21g")]
        [DisplayName("Valid From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldFr")]
        #endif
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ValidFrom { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ValidFrom { get; init; } 
        #else
        public System.DateOnly? ValidFrom { get; set; } 
        #endif
        
        /// <summary>
        /// Ending validity date for the contact.
        /// </summary>
        [IsoId("_vDRXk4v3Eei289CGNqs21g")]
        [DisplayName("Valid To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldTo")]
        #endif
        [IsoXmlTag("VldTo")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ValidTo { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ValidTo { get; init; } 
        #else
        public System.DateOnly? ValidTo { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
