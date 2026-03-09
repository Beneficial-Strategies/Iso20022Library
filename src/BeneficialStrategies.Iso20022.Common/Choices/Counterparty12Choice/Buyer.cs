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
namespace BeneficialStrategies.Iso20022.Choices.Counterparty12Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_5ToeQc3yEee5nJBZsW8MFQ")]
    [DisplayName("Buyer")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Buyer : Counterparty12Choice_
    #else
    public partial class Buyer : Counterparty12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Buyer instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Buyer( PartyIdentification104Choice_ reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_qIo4_83yEee5nJBZsW8MFQ")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification104Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification104Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification104Choice_ Identification { get; init; } 
        #else
        public PartyIdentification104Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_qIo5B83yEee5nJBZsW8MFQ")]
        [DisplayName("LEI")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LEI")]
        #endif
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? LEI { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LEI { get; init; } 
        #else
        public System.String? LEI { get; set; } 
        #endif
        
        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_qIo5Cc3yEee5nJBZsW8MFQ")]
        [DisplayName("Alternate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AltrnId")]
        #endif
        [IsoXmlTag("AltrnId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
        #else
        public AlternatePartyIdentification9? AlternateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_qIo5Ec3yEee5nJBZsW8MFQ")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesAccount30? SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount30? SafekeepingAccount { get; init; } 
        #else
        public SecuritiesAccount30? SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_qIo5Gc3yEee5nJBZsW8MFQ")]
        [DisplayName("Processing Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrcgDt")]
        #endif
        [IsoXmlTag("PrcgDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? ProcessingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? ProcessingDate { get; init; } 
        #else
        public DateAndDateTime2Choice_? ProcessingDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_qIo5Ic3yEee5nJBZsW8MFQ")]
        [DisplayName("Processing Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrcgId")]
        #endif
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ProcessingIdentification { get; init; } 
        #else
        public System.String? ProcessingIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_qIo5Kc3yEee5nJBZsW8MFQ")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyTextInformation3? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyTextInformation3? AdditionalInformation { get; init; } 
        #else
        public PartyTextInformation3? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
