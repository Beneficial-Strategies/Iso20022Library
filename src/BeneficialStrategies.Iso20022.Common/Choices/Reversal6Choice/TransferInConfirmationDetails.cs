// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reversal6Choice
{
    /// <summary>
    /// Details of the transfer in confirmation to be reversed.
    /// </summary>
    [IsoId("_gV6FEz8BEeSIqOPJHpnleA")]
    [DisplayName("Transfer In Confirmation Details")]
    public partial record TransferInConfirmationDetails : Reversal6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_gwr8lz8BEeSIqOPJHpnleA")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; } 
        
        /// <summary>
        /// General information related to the transfer of a financial instrument.
        /// </summary>
        [IsoId("_gwr8mT8BEeSIqOPJHpnleA")]
        [DisplayName("Transfer Details")]
        [IsoXmlTag("TrfDtls")]
        public ValueList<Transfer29> TransferDetails { get; init; } = new ValueList<Transfer29>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _gwr8mT8BEeSIqOPJHpnleA
        
        /// <summary>
        /// Information related to the account into which the financial instrument was received.
        /// </summary>
        [IsoId("_gwr8mz8BEeSIqOPJHpnleA")]
        [DisplayName("Account Details")]
        [IsoXmlTag("AcctDtls")]
        public required InvestmentAccount40 AccountDetails { get; init; } 
        
        /// <summary>
        /// Information related to the delivering side of the transfer.
        /// </summary>
        [IsoId("_gwr8nT8BEeSIqOPJHpnleA")]
        [DisplayName("Settlement Details")]
        [IsoXmlTag("SttlmDtls")]
        public DeliverInformation14? SettlementDetails { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_gwr8nz8BEeSIqOPJHpnleA")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; } 
        
        
        #nullable disable
        
    }
}
