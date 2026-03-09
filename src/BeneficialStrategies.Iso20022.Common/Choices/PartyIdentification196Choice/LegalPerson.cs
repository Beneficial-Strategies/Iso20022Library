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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification196Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_8gnOcDtnEemIf7eyjCwinw")]
    [DisplayName("Legal Person")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record LegalPerson : PartyIdentification196Choice_
    #else
    public partial class LegalPerson : PartyIdentification196Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a LegalPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public LegalPerson( NameAndAddress17 reqNameAndAddress,PartyIdentification198Choice_ reqIdentification )
        {
            NameAndAddress = reqNameAndAddress;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_D79wQDtpEemIf7eyjCwinw")]
        [DisplayName("Name And Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmAndAdr")]
        #endif
        [IsoXmlTag("NmAndAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NameAndAddress17 NameAndAddress { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NameAndAddress17 NameAndAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NameAndAddress17 NameAndAddress { get; init; } 
        #else
        public NameAndAddress17 NameAndAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_GXuoEDtpEemIf7eyjCwinw")]
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
        [IsoId("_hJ5qEDtpEemIf7eyjCwinw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification198Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification198Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification198Choice_ Identification { get; init; } 
        #else
        public PartyIdentification198Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which the company is incorporated or legally registered. 
        /// </summary>
        [IsoId("_cDVrcIkyEemZteIrPMIV3g")]
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
        
        /// <summary>
        /// Economical activity of the  investor.
        /// </summary>
        [IsoId("_ePTTEIk6EemZteIrPMIV3g")]
        [DisplayName("Activity Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ActvtyInd")]
        #endif
        [IsoXmlTag("ActvtyInd")]
        [IsoSimpleType(IsoSimpleType.ISICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISICIdentifier? ActivityIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ActivityIndicator { get; init; } 
        #else
        public System.String? ActivityIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Type of investor.
        /// </summary>
        [IsoId("_aShGsYk1EemZteIrPMIV3g")]
        [DisplayName("Investor Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstrTp")]
        #endif
        [IsoXmlTag("InvstrTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InvestorType1Choice_? InvestorType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestorType1Choice_? InvestorType { get; init; } 
        #else
        public InvestorType1Choice_? InvestorType { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information about the ownership on an asset.
        /// </summary>
        [IsoId("_uX0X0Iz1EemXJvzC2Wyt1g")]
        [DisplayName("Ownership")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ownrsh")]
        #endif
        [IsoXmlTag("Ownrsh")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Ownership1? Ownership { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Ownership1? Ownership { get; init; } 
        #else
        public Ownership1? Ownership { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
