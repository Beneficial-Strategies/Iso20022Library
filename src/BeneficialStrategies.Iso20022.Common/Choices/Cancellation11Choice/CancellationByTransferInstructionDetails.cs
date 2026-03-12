// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cancellation11Choice
{
    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_8u6kcSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    public partial record CancellationByTransferInstructionDetails : Cancellation11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_9MFBnSPvEeWQjryFgN2ITg")]
        [DisplayName("Primary Individual Investor")]
        [IsoXmlTag("PmryIndvInvstr")]
        public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
        
        /// <summary>
        /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_9MFBnyPvEeWQjryFgN2ITg")]
        [DisplayName("Secondary Individual Investor")]
        [IsoXmlTag("ScndryIndvInvstr")]
        public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
        
        /// <summary>
        /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_9MFBoSPvEeWQjryFgN2ITg")]
        [DisplayName("Other Individual Investor")]
        [IsoXmlTag("OthrIndvInvstr")]
        public IndividualPerson8? OtherIndividualInvestor { get; init; } 
        
        /// <summary>
        /// Information identifying the primary corporate investor, for example, name and address.
        /// </summary>
        [IsoId("_9MFBoyPvEeWQjryFgN2ITg")]
        [DisplayName("Primary Corporate Investor")]
        [IsoXmlTag("PmryCorpInvstr")]
        public Organisation21? PrimaryCorporateInvestor { get; init; } 
        
        /// <summary>
        /// Information identifying the secondary corporate investor, for example, name and address.
        /// </summary>
        [IsoId("_9MFBpSPvEeWQjryFgN2ITg")]
        [DisplayName("Secondary Corporate Investor")]
        [IsoXmlTag("ScndryCorpInvstr")]
        public Organisation21? SecondaryCorporateInvestor { get; init; } 
        
        /// <summary>
        /// Information identifying the other corporate investors, for example, name and address.
        /// </summary>
        [IsoId("_9MFBpyPvEeWQjryFgN2ITg")]
        [DisplayName("Other Corporate Investor")]
        [IsoXmlTag("OthrCorpInvstr")]
        public Organisation21? OtherCorporateInvestor { get; init; } 
        
        /// <summary>
        /// Identification of an account owned by the investor at the old plan manager (account servicer).
        /// </summary>
        [IsoId("_9MFBqSPvEeWQjryFgN2ITg")]
        [DisplayName("Transferor Account")]
        [IsoXmlTag("TrfrAcct")]
        public required Account19 TransferorAccount { get; init; } 
        
        /// <summary>
        /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
        /// </summary>
        [IsoId("_9MFBqyPvEeWQjryFgN2ITg")]
        [DisplayName("Nominee Account")]
        [IsoXmlTag("NmneeAcct")]
        public Account19? NomineeAccount { get; init; } 
        
        /// <summary>
        /// Information related to the institution to which the financial instrument is to be transferred.
        /// </summary>
        [IsoId("_9MFBrSPvEeWQjryFgN2ITg")]
        [DisplayName("Transferee")]
        [IsoXmlTag("Trfee")]
        public required PartyIdentification70Choice_ Transferee { get; init; } 
        
        /// <summary>
        /// Identification of a related party or intermediary.
        /// </summary>
        [IsoId("_ky2vYSYdEeWJkOUkQWu90g")]
        [DisplayName("Intermediary Information")]
        [IsoXmlTag("IntrmyInf")]
        public Intermediary34? IntermediaryInformation { get; init; } 
        
        /// <summary>
        /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
        /// </summary>
        [IsoId("_9MFBryPvEeWQjryFgN2ITg")]
        [DisplayName("Cash Account")]
        [IsoXmlTag("CshAcct")]
        public CashAccount34? CashAccount { get; init; } 
        
        /// <summary>
        /// Details of the transfer to be cancelled.
        /// </summary>
        [IsoId("_9MFBsSPvEeWQjryFgN2ITg")]
        [DisplayName("Product Transfer And Reference")]
        [IsoXmlTag("PdctTrfAndRef")]
        public required ISATransfer25 ProductTransferAndReference { get; init; } 
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_9MFBsyPvEeWQjryFgN2ITg")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; } 
        
        
        #nullable disable
        
    }
}
