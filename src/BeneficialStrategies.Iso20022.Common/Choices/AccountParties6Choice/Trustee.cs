// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties6Choice
{
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_I9Ac9QhDEeSUPbC7DbLJpQ")]
    [DisplayName("Trustee")]
    public record Trustee : AccountParties6Choice_
    {
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_Gzhn8whDEeSUPbC7DbLJpQ")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party24Choice_ Party { get; init; }

        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_Gzhn9QhDEeSUPbC7DbLJpQ")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; }

        /// <summary>
        /// Percentage of ownership or beneficiary ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
        /// </summary>
        [IsoId("_Gzhn9whDEeSUPbC7DbLJpQ")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; }

        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_Gzhn-QhDEeSUPbC7DbLJpQ")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; }

        /// <summary>
        /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
        /// </summary>
        [IsoId("_Gzhn-whDEeSUPbC7DbLJpQ")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; }

        /// <summary>
        /// Indicates whether the account owner signature is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_Gzhn_QhDEeSUPbC7DbLJpQ")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; }

        /// <summary>
        /// Information related to the party profile to be inserted or deleted.
        /// </summary>
        [IsoId("_Gzhn_whDEeSUPbC7DbLJpQ")]
        [DisplayName("Modified Investor Profile Validation")]
        [IsoXmlTag("ModfdInvstrPrflVldtn")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<ModificationScope19> ModifiedInvestorProfileValidation { get; init; } = [];

        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_GzhoAQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; }

        /// <summary>
        /// Specifies how information is sent to the account holder.
        /// </summary>
        [IsoId("_GzhoAwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Information Distribution")]
        [IsoXmlTag("InfDstrbtn")]
        public InformationDistribution1Code? InformationDistribution { get; init; }

        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor.
        /// </summary>
        [IsoId("_Vs-NYQjQEeS5F6qHcKOrew")]
        [DisplayName("FATCA Form Type")]
        [IsoXmlTag("FATCAFormTp")]
        public FATCAForm1Choice_? FATCAFormType { get; init; }

        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor.
        /// </summary>
        [IsoId("_TrvjMQjVEeS5F6qHcKOrew")]
        [DisplayName("FATCA Status")]
        [IsoXmlTag("FATCASts")]
        public FATCAStatus1? FATCAStatus { get; init; }
    }
}
