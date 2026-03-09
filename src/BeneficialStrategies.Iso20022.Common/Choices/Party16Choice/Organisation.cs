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
namespace BeneficialStrategies.Iso20022.Choices.Party16Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_l9lC0RRkEeOKWo1NF21OVw")]
    [DisplayName("Organisation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Organisation : Party16Choice_
    #else
    public partial class Organisation : Party16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Organisation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Organisation( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_LRpywRQLEeKCyZtSz_i3FA")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
        /// </summary>
        [IsoId("_LRpyxRQLEeKCyZtSz_i3FA")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification4Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification4Choice_? Identification { get; init; } 
        #else
        public PartyIdentification4Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose of the organisation, eg, charity.
        /// </summary>
        [IsoId("_LRpyyRQLEeKCyZtSz_i3FA")]
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
        /// Country of taxation of an organisation.
        /// </summary>
        [IsoId("_LRpyzRQLEeKCyZtSz_i3FA")]
        [DisplayName("Taxation Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxtnCtry")]
        #endif
        [IsoXmlTag("TaxtnCtry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? TaxationCountry { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? TaxationCountry { get; init; } 
        #else
        public string? TaxationCountry { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_LRpy0RQLEeKCyZtSz_i3FA")]
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
        [IsoId("_LRpy1RQLEeKCyZtSz_i3FA")]
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
        /// Number assigned by a tax authority to an entity.
        /// </summary>
        [IsoId("_LRpy2RQLEeKCyZtSz_i3FA")]
        [DisplayName("Tax Identification Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxIdNb")]
        #endif
        [IsoXmlTag("TaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TaxIdentificationNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TaxIdentificationNumber { get; init; } 
        #else
        public System.String? TaxIdentificationNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Number assigned by a national registration authority to an entity.
        /// </summary>
        [IsoId("_LRpy3RQLEeKCyZtSz_i3FA")]
        [DisplayName("National Registration Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NtlRegnNb")]
        #endif
        [IsoXmlTag("NtlRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? NationalRegistrationNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? NationalRegistrationNumber { get; init; } 
        #else
        public System.String? NationalRegistrationNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_LRpy4RQLEeKCyZtSz_i3FA")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress3> PostalAddress { get; init; } = new ValueList<PostalAddress3>(){};
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_LRpy5RQLEeKCyZtSz_i3FA")]
        [DisplayName("Primary Communication Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmryComAdr")]
        #endif
        [IsoXmlTag("PmryComAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
        #else
        public CommunicationAddress3? PrimaryCommunicationAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_LRpy6RQLEeKCyZtSz_i3FA")]
        [DisplayName("Secondary Communication Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ScndryComAdr")]
        #endif
        [IsoXmlTag("ScndryComAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
        #else
        public CommunicationAddress3? SecondaryCommunicationAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_mQL1xRQLEeKCyZtSz_i3FA")]
        [DisplayName("Additional Regulatory Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRgltryInf")]
        #endif
        [IsoXmlTag("AddtlRgltryInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        #else
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
