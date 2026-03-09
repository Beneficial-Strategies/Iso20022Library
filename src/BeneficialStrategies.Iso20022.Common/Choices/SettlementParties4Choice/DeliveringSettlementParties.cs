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
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties4Choice
{
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_CB0GoWpSEeSgo9vJrfSF_Q")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DeliveringSettlementParties : SettlementParties4Choice_
    #else
    public partial class DeliveringSettlementParties : SettlementParties4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DeliveringSettlementParties instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DeliveringSettlementParties( PartyIdentification34Choice_ reqDepository,PartyIdentificationAndAccount102 reqParty1 )
        {
            Depository = reqDepository;
            Party1 = reqParty1;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
        /// </summary>
        [IsoId("_YBN9N2pSEeSgo9vJrfSF_Q")]
        [DisplayName("Depository")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dpstry")]
        #endif
        [IsoXmlTag("Dpstry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification34Choice_ Depository { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification34Choice_ Depository { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification34Choice_ Depository { get; init; } 
        #else
        public PartyIdentification34Choice_ Depository { get; set; } 
        #endif
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the depository.
        /// </summary>
        [IsoId("_YBN9OWpSEeSgo9vJrfSF_Q")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty1")]
        #endif
        [IsoXmlTag("Pty1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentificationAndAccount102 Party1 { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentificationAndAccount102 Party1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount102 Party1 { get; init; } 
        #else
        public PartyIdentificationAndAccount102 Party1 { get; set; } 
        #endif
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the party 1.
        /// </summary>
        [IsoId("_YBN9O2pSEeSgo9vJrfSF_Q")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty2")]
        #endif
        [IsoXmlTag("Pty2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentificationAndAccount102? Party2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentificationAndAccount102? Party2 { get; init; } 
        #else
        public PartyIdentificationAndAccount102? Party2 { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the securities settlement system to be used.
        /// </summary>
        [IsoId("_YBN9PWpSEeSgo9vJrfSF_Q")]
        [DisplayName("Securities Settlement System")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesSttlmSys")]
        #endif
        [IsoXmlTag("SctiesSttlmSys")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SecuritiesSettlementSystem { get; init; } 
        #else
        public System.String? SecuritiesSettlementSystem { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
