// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties4Choice
{
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_CB0Go2pSEeSgo9vJrfSF_Q")]
    [DisplayName("Receiving Settlement Parties")]
    public partial record ReceivingSettlementParties : SettlementParties4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
        /// </summary>
        [IsoId("_b8gHBWpSEeSgo9vJrfSF_Q")]
        [DisplayName("Depository")]
        [IsoXmlTag("Dpstry")]
        public required PartyIdentification34Choice_ Depository { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the depository.
        /// </summary>
        [IsoId("_b8gHB2pSEeSgo9vJrfSF_Q")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty1")]
        public required PartyIdentificationAndAccount102 Party1 { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the party 1.
        /// </summary>
        [IsoId("_b8gHCWpSEeSgo9vJrfSF_Q")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty2")]
        public PartyIdentificationAndAccount102? Party2 { get; init; } 
        
        /// <summary>
        /// Identifies the securities settlement system to be used.
        /// </summary>
        [IsoId("_b8gHC2pSEeSgo9vJrfSF_Q")]
        [DisplayName("Securities Settlement System")]
        [IsoXmlTag("SctiesSttlmSys")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
        
        
        #nullable disable
        
    }
}
