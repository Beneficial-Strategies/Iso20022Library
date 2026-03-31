// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties1Choice
{
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_5n7tpRdAEeK5g-3oYI0_9Q")]
    [DisplayName("Joint Owner")]
    [IsoXmlTag("JntOwnr")]
    public record JointOwner : AccountParties1Choice_
    {
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_Slgv8BdCEeK5g-3oYI0_9Q")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party14Choice_ Party { get; init; }

        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_dhPoQBdDEeK5g-3oYI0_9Q")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; }

        /// <summary>
        /// Information to support Know Your Customer processes.
        /// </summary>
        [IsoId("_KdgCQROAEeKjmvxNCObNeQ")]
        [DisplayName("Investor Profile Validation")]
        [IsoXmlTag("InvstrPrflVldtn")]
        public PartyProfileInformation2? InvestorProfileValidation { get; init; }

        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_KdgCRROAEeKjmvxNCObNeQ")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; }

        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_KdgCSROAEeKjmvxNCObNeQ")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; }

        /// <summary>
        /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
        /// </summary>
        [IsoId("_KdgCTROAEeKjmvxNCObNeQ")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; }

        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_KdgCUROAEeKjmvxNCObNeQ")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; }

        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_r4UWoBOBEeKjmvxNCObNeQ")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; }

        /// <summary>
        /// Specifies how information is sent to the account holder.
        /// </summary>
        [IsoId("_u_ftgBOCEeKjmvxNCObNeQ")]
        [DisplayName("Information Distribution")]
        [IsoXmlTag("InfDstrbtn")]
        public InformationDistribution1Code? InformationDistribution { get; init; }
    }
}
