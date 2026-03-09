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
namespace BeneficialStrategies.Iso20022.Choices.Party9Choice
{
    /// <summary>
    /// Identification of a person or an organisation.
    /// </summary>
    [IsoId("_PW59s9p-Ed-ak6NoX_4Aeg_-1623662466")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OrganisationIdentification : Party9Choice_
    #else
    public partial class OrganisationIdentification : Party9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PWwzxtp-Ed-ak6NoX_4Aeg_-950561134")]
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
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PWwzx9p-Ed-ak6NoX_4Aeg_1349169450")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PostalAddress6? PostalAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress6? PostalAddress { get; init; } 
        #else
        public PostalAddress6? PostalAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification of a party.
        /// </summary>
        [IsoId("_PWwzyNp-Ed-ak6NoX_4Aeg_1214397538")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Party10Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party10Choice_? Identification { get; init; } 
        #else
        public Party10Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
        /// </summary>
        [IsoId("_PW59sNp-Ed-ak6NoX_4Aeg_1173508778")]
        [DisplayName("Country Of Residence")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtryOfRes")]
        #endif
        [IsoXmlTag("CtryOfRes")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? CountryOfResidence { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? CountryOfResidence { get; init; } 
        #else
        public string? CountryOfResidence { get; set; } 
        #endif
        
        /// <summary>
        /// Set of elements used to indicate how to contact the party.
        /// </summary>
        [IsoId("_PW59sdp-Ed-ak6NoX_4Aeg_999422025")]
        [DisplayName("Contact Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtctDtls")]
        #endif
        [IsoXmlTag("CtctDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContactDetails2? ContactDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContactDetails2? ContactDetails { get; init; } 
        #else
        public ContactDetails2? ContactDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
