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
namespace BeneficialStrategies.Iso20022.Choices.Counterparty13Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_9jKai9LCEeiN28wlpBQScw")]
    [DisplayName("Buyer")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Buyer : Counterparty13Choice_
    #else
    public partial class Buyer : Counterparty13Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Buyer instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Buyer( PartyIdentification120Choice_ reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_7pKzA9LCEeiN28wlpBQScw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification120Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification120Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification120Choice_ Identification { get; init; } 
        #else
        public PartyIdentification120Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_7pKzC9LCEeiN28wlpBQScw")]
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
        [IsoId("_7pKzDdLCEeiN28wlpBQScw")]
        [DisplayName("Alternate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AltrnId")]
        #endif
        [IsoXmlTag("AltrnId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
        #else
        public AlternatePartyIdentification7? AlternateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_7pKzFdLCEeiN28wlpBQScw")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesAccount19? SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount19? SafekeepingAccount { get; init; } 
        #else
        public SecuritiesAccount19? SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_7pKzHdLCEeiN28wlpBQScw")]
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
        [IsoId("_7pKzJdLCEeiN28wlpBQScw")]
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
        [IsoId("_7pKzLdLCEeiN28wlpBQScw")]
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
