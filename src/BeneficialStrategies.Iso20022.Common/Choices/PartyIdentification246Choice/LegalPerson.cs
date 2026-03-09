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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification246Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_ATj_QTUDEe2tRf29bleifQ")]
    [DisplayName("Legal Person")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record LegalPerson : PartyIdentification246Choice_
    #else
    public partial class LegalPerson : PartyIdentification246Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a LegalPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public LegalPerson( PersonName2 reqNameAndAddress )
        {
            NameAndAddress = reqNameAndAddress;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_ArjogTUDEe2tRf29bleifQ")]
        [DisplayName("Name And Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmAndAdr")]
        #endif
        [IsoXmlTag("NmAndAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PersonName2 NameAndAddress { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PersonName2 NameAndAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PersonName2 NameAndAddress { get; init; } 
        #else
        public PersonName2 NameAndAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_ArjogzUDEe2tRf29bleifQ")]
        [DisplayName("Email Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EmailAdr")]
        #endif
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? EmailAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailAddress { get; init; } 
        #else
        public System.String? EmailAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_ArjohTUDEe2tRf29bleifQ")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification198Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification198Choice_? Identification { get; init; } 
        #else
        public PartyIdentification198Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the shareholder in the company share register.
        /// </summary>
        [IsoId("_ArjohzUDEe2tRf29bleifQ")]
        [DisplayName("Company Register Shareholder Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CpnyRegrShrhldrId")]
        #endif
        [IsoXmlTag("CpnyRegrShrhldrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CompanyRegisterShareholderIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CompanyRegisterShareholderIdentification { get; init; } 
        #else
        public System.String? CompanyRegisterShareholderIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which the company is incorporated or legally registered.
        /// </summary>
        [IsoId("_LunGQDUDEe2tRf29bleifQ")]
        [DisplayName("Country Of Incorporation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtryOfIncorprtn")]
        #endif
        [IsoXmlTag("CtryOfIncorprtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? CountryOfIncorporation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? CountryOfIncorporation { get; init; } 
        #else
        public string? CountryOfIncorporation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
