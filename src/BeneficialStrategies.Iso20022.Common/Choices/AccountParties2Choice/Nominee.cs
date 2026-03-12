// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountParties2Choice
{
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_envDdhdQEeK5g-3oYI0_9Q")]
    [DisplayName("Nominee")]
    public partial record Nominee : AccountParties2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_6NdpNBdQEeK5g-3oYI0_9Q")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party14Choice_ Party { get; init; } 
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_6NdpNxdQEeK5g-3oYI0_9Q")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        
        /// <summary>
        /// Percentage of ownership or beneficiary ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_LOyGhROGEeKjmvxNCObNeQ")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_LOyGiROGEeKjmvxNCObNeQ")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; } 
        
        /// <summary>
        /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
        /// </summary>
        [IsoId("_LOyGjROGEeKjmvxNCObNeQ")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; } 
        
        /// <summary>
        /// Indicates whether the account owner signature is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_LOyGkROGEeKjmvxNCObNeQ")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
        
        /// <summary>
        /// Information related to the party profile to be inserted or deleted.
        /// </summary>
        [IsoId("_LOyGlROGEeKjmvxNCObNeQ")]
        [DisplayName("Modified Investor Profile Validation")]
        [IsoXmlTag("ModfdInvstrPrflVldtn")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<ModificationScope14> ModifiedInvestorProfileValidation { get; init; } = new ValueList<ModificationScope14>(){};
        
        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_RectqBOGEeKjmvxNCObNeQ")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; } 
        
        /// <summary>
        /// Specifies how information is sent to the account holder.
        /// </summary>
        [IsoId("_RectrROGEeKjmvxNCObNeQ")]
        [DisplayName("Information Distribution")]
        [IsoXmlTag("InfDstrbtn")]
        public InformationDistribution1Code? InformationDistribution { get; init; } 
        
        
        #nullable disable
        
    }
}
