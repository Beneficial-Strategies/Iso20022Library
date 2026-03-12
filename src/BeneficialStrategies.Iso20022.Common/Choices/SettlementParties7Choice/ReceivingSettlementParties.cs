// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementParties7Choice
{
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_tf3bE4pIEeaNTaanBSMWmg")]
    [DisplayName("Receiving Settlement Parties")]
    public partial record ReceivingSettlementParties : SettlementParties7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
        /// </summary>
        [IsoId("_vAhGRYFvEeWtPe6Crjmeug")]
        [DisplayName("Depository")]
        [IsoXmlTag("Dpstry")]
        public required PartyIdentification102Choice_ Depository { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the depository.
        /// </summary>
        [IsoId("_vAhGR4FvEeWtPe6Crjmeug")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty1")]
        public required PartyIdentificationAndAccount126 Party1 { get; init; } 
        
        /// <summary>
        /// Party that, in a settlement chain interacts with the party 1.
        /// </summary>
        [IsoId("_vAhGSYFvEeWtPe6Crjmeug")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty2")]
        public PartyIdentificationAndAccount127? Party2 { get; init; } 
        
        
        #nullable disable
        
    }
}
