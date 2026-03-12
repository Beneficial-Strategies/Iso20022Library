// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountParties7Choice
{
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_J0DZtwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Custodian For Minor")]
    public partial record CustodianForMinor : AccountParties7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_DxEjkQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party23Choice_ Party { get; init; } 
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_DxEjkwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        
        /// <summary>
        /// Information to support Know Your Customer processes.
        /// </summary>
        [IsoId("_DxEjlQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Investor Profile Validation")]
        [IsoXmlTag("InvstrPrflVldtn")]
        public PartyProfileInformation4? InvestorProfileValidation { get; init; } 
        
        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_DxEjlwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_DxEjmQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; } 
        
        /// <summary>
        /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
        /// </summary>
        [IsoId("_DxEjmwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; } 
        
        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_DxEjnQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
        
        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_DxEjnwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; } 
        
        /// <summary>
        /// Specifies how information is sent to the account holder.
        /// </summary>
        [IsoId("_DxEjoQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Information Distribution")]
        [IsoXmlTag("InfDstrbtn")]
        public InformationDistribution1Code? InformationDistribution { get; init; } 
        
        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor.
        /// </summary>
        [IsoId("_Ul20UQjQEeS5F6qHcKOrew")]
        [DisplayName("FATCA Form Type")]
        [IsoXmlTag("FATCAFormTp")]
        public FATCAForm1Choice_? FATCAFormType { get; init; } 
        
        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor.
        /// </summary>
        [IsoId("_YNqBcQjQEeS5F6qHcKOrew")]
        [DisplayName("FATCA Status")]
        [IsoXmlTag("FATCASts")]
        public FATCAStatus1? FATCAStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
