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
namespace BeneficialStrategies.Iso20022.Choices.Party7Choice
{
    /// <summary>
    /// Identification of a person or an organisation.
    /// </summary>
    [IsoId("_Pa7iGNp-Ed-ak6NoX_4Aeg_2099219104")]
    [DisplayName("Party")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Party : Party7Choice_
    #else
    public partial class Party : Party7Choice_
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
        [IsoId("_PaxxFtp-Ed-ak6NoX_4Aeg_-1092208075")]
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
        [IsoId("_PaxxF9p-Ed-ak6NoX_4Aeg_-1092207954")]
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
        [IsoId("_PaxxGNp-Ed-ak6NoX_4Aeg_-1092207900")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Party6Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party6Choice_? Identification { get; init; } 
        #else
        public Party6Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
        /// </summary>
        [IsoId("_PaxxGdp-Ed-ak6NoX_4Aeg_-1092208016")]
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
        [IsoId("_Pa7iENp-Ed-ak6NoX_4Aeg_935029789")]
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
