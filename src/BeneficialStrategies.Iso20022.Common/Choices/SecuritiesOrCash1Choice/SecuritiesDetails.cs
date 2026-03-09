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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesOrCash1Choice
{
    /// <summary>
    /// Securities settlement chain parties, accounts and other details.
    /// </summary>
    [IsoId("_v5oPQDchEeOA3chqL9a4Rw")]
    [DisplayName("Securities Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesDetails : SecuritiesOrCash1Choice_
    #else
    public partial class SecuritiesDetails : SecuritiesOrCash1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesDetails( SettlementParties32 reqStandingSettlementParties )
        {
            StandingSettlementParties = reqStandingSettlementParties;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Parties through which settlement is to take place.
        /// </summary>
        [IsoId("_-Rf3QTciEeOKPpUjhHfcCQ")]
        [DisplayName("Standing Settlement Parties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StgSttlmPties")]
        #endif
        [IsoXmlTag("StgSttlmPties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementParties32 StandingSettlementParties { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementParties32 StandingSettlementParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementParties32 StandingSettlementParties { get; init; } 
        #else
        public SettlementParties32 StandingSettlementParties { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier needed for settlement purposes. This identifier could be, for example, an identifier that identifies an institution or agent at a CDS or ICSD (Depository Trust Clearing Corporation (DTC) Institution ID or DTC Agent ID). It could also be a local tax identification number or an ‘investor identification’, as mandated by local market practice.
        /// </summary>
        [IsoId("_HjKEoNQiEeKvJeoOII0e7w")]
        [DisplayName("Local Market Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LclMktId")]
        #endif
        [IsoXmlTag("LclMktId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericIdentification49? LocalMarketIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification49? LocalMarketIdentification { get; init; } 
        #else
        public GenericIdentification49? LocalMarketIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Registration information required for settlement. For some markets, for example, Spain (Iberclear) registration details are mandatory and should be part of the SSI. In some cases, the name of the institution is different than what&apos;s provided in the BIC Directory. If this is the case, the name should be provided.
        /// </summary>
        [IsoId("_XT29QNQiEeKvJeoOII0e7w")]
        [DisplayName("Registration Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnDtls")]
        #endif
        [IsoXmlTag("RegnDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification99Choice_? RegistrationDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification99Choice_? RegistrationDetails { get; init; } 
        #else
        public PartyIdentification99Choice_? RegistrationDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
