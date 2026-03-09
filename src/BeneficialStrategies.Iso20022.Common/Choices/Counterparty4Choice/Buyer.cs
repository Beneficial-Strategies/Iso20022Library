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
namespace BeneficialStrategies.Iso20022.Choices.Counterparty4Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_eaw-Q-aOEd-q8fx_Zl_34A")]
    [DisplayName("Buyer")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Buyer : Counterparty4Choice_
    #else
    public partial class Buyer : Counterparty4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Buyer instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Buyer( PartyIdentification43Choice_ reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_eanNi-aOEd-q8fx_Zl_34A")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification43Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification43Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43Choice_ Identification { get; init; } 
        #else
        public PartyIdentification43Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_eanNjeaOEd-q8fx_Zl_34A")]
        [DisplayName("Alternate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AltrnId")]
        #endif
        [IsoXmlTag("AltrnId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
        #else
        public AlternatePartyIdentification2? AlternateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_eanNj-aOEd-q8fx_Zl_34A")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesAccount13? SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount13? SafekeepingAccount { get; init; } 
        #else
        public SecuritiesAccount13? SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_eanNkeaOEd-q8fx_Zl_34A")]
        [DisplayName("Processing Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrcgDt")]
        #endif
        [IsoXmlTag("PrcgDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
        #else
        public DateAndDateTimeChoice_? ProcessingDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_eanNk-aOEd-q8fx_Zl_34A")]
        [DisplayName("Processing Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrcgId")]
        #endif
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ProcessingIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ProcessingIdentification { get; init; } 
        #else
        public System.String? ProcessingIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_eanNleaOEd-q8fx_Zl_34A")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyTextInformation1? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyTextInformation1? AdditionalInformation { get; init; } 
        #else
        public PartyTextInformation1? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
