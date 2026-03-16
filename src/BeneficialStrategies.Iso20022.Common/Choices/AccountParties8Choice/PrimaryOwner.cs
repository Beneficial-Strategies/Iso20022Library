// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties8Choice
{
    /// <summary>
    /// Single owner of the account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_J1TYUyCBEeWhHbfCMWc1cw")]
    [DisplayName("Primary Owner")]
    [IsoXmlTag("PmryOwnr")]
    public record PrimaryOwner : AccountParties8Choice_
    {
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_HQ3ssSCBEeWhHbfCMWc1cw")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party31Choice_ Party { get; init; }

        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_HQ3ssyCBEeWhHbfCMWc1cw")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; }

        /// <summary>
        /// Information to support Know Your Customer processes.
        /// </summary>
        [IsoId("_HQ3stSCBEeWhHbfCMWc1cw")]
        [DisplayName("Investor Profile Validation")]
        [IsoXmlTag("InvstrPrflVldtn")]
        public PartyProfileInformation5? InvestorProfileValidation { get; init; }

        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
        /// </summary>
        [IsoId("_HQ3styCBEeWhHbfCMWc1cw")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; }

        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_HQ3suSCBEeWhHbfCMWc1cw")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; }

        /// <summary>
        /// Indicates whether an owner of the account may benefit from a fiscal exemption or amnesty, for example, when declaring overseas investments.
        /// </summary>
        [IsoId("_HQ3suyCBEeWhHbfCMWc1cw")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; }

        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_HQ3svSCBEeWhHbfCMWc1cw")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; }

        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_HQ3svyCBEeWhHbfCMWc1cw")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; }

        /// <summary>
        /// Type of information that must be provided to the account holder.
        /// </summary>
        [IsoId("_HQ3swSCBEeWhHbfCMWc1cw")]
        [DisplayName("Notification")]
        [IsoXmlTag("Ntfctn")]
        public Notification2? Notification { get; init; }

        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor or account owner.
        /// </summary>
        [IsoId("_HQ3swyCBEeWhHbfCMWc1cw")]
        [DisplayName("FATCA Form Type")]
        [IsoXmlTag("FATCAFormTp")]
        public FATCAForm1Choice_? FATCAFormType { get; init; }

        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor or account owner.
        /// </summary>
        [IsoId("_HQ3sxSCBEeWhHbfCMWc1cw")]
        [DisplayName("FATCA Status")]
        [IsoXmlTag("FATCASts")]
        public FATCAStatus2? FATCAStatus { get; init; }

        /// <summary>
        /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_ds7pESCMEeWJd9HF2tO7BA")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        public GenericIdentification82? OtherIdentification { get; init; }

        /// <summary>
        /// Tax advantage specific to the account party.
        /// </summary>
        [IsoId("_xQT50YkeEeWFCoSYeBm65Q")]
        [DisplayName("Tax Exemption")]
        [IsoXmlTag("TaxXmptn")]
        public TaxExemptionReason2Choice_? TaxExemption { get; init; }

        /// <summary>
        /// Details for the reporting of tax, for example, the country of taxation.
        /// </summary>
        [IsoId("_s9asYCCTEeWJd9HF2tO7BA")]
        [DisplayName("Tax Reporting")]
        [IsoXmlTag("TaxRptg")]
        public TaxReporting1? TaxReporting { get; init; }

        /// <summary>
        /// Language in which the organisation or person communicates.
        /// </summary>
        [IsoId("_-t0L4iCTEeWJd9HF2tO7BA")]
        [DisplayName("Language")]
        [IsoXmlTag("Lang")]
        public LanguageCode? Language { get; init; }

        /// <summary>
        /// Method used for postal mailing.
        /// </summary>
        [IsoId("_wPINYCCWEeWJd9HF2tO7BA")]
        [DisplayName("Mail Type")]
        [IsoXmlTag("MailTp")]
        public MailType1Choice_? MailType { get; init; }

        /// <summary>
        /// Country and residential status of the organisation or individual person.
        /// </summary>
        [IsoId("_KPneUSCYEeWJd9HF2tO7BA")]
        [DisplayName("Country And Residential Status")]
        [IsoXmlTag("CtryAndResdtlSts")]
        public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; }

        /// <summary>
        /// Annual wealth of the individual person or share capital value of the legal entity and date on which the annual wealth of the individual person was registered or declared or the date the stock value of the organisation was registered.
        /// </summary>
        [IsoId("_UHlB8CCYEeWJd9HF2tO7BA")]
        [DisplayName("Monetary Wealth")]
        [IsoXmlTag("MntryWlth")]
        public DateAndAmount1? MonetaryWealth { get; init; }

        /// <summary>
        /// Amount of total assets minus liabilities of the individual person or the amount of the difference between assets and liabilities plus rights over obligations (net equity) of the organisation and the date on which the equity value was registered.
        /// </summary>
        [IsoId("_ZtS30CCZEeWJd9HF2tO7BA")]
        [DisplayName("Equity Value")]
        [IsoXmlTag("EqtyVal")]
        public DateAndAmount1? EquityValue { get; init; }

        /// <summary>
        /// Resource or value owned or used by a third-party company and the date on which the working capital amount was registered.
        /// </summary>
        [IsoId("_j2_rsCCZEeWJd9HF2tO7BA")]
        [DisplayName("Working Capital")]
        [IsoXmlTag("WorkgCptl")]
        public DateAndAmount1? WorkingCapital { get; init; }

        /// <summary>
        /// Account owner&apos;s connection with the trading party or broker.
        /// </summary>
        [IsoId("_qXarwCCZEeWJd9HF2tO7BA")]
        [DisplayName("Company Link")]
        [IsoXmlTag("CpnyLk")]
        public CompanyLink1Choice_? CompanyLink { get; init; }

        /// <summary>
        /// Reference to be specified when a letter (for example, an order confirmation) is sent by an automated mailing system.
        /// </summary>
        [IsoId("_uTDc0CFHEeWgV9SQSyaAog")]
        [DisplayName("Electronic Mailing Service Reference")]
        [IsoXmlTag("ElctrncMlngSvcRef")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? ElectronicMailingServiceReference { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_VOd8k1xkEeWvPv3PXpS3fw")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress6? PrimaryCommunicationAddress { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_VOd8lFxkEeWvPv3PXpS3fw")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress6? SecondaryCommunicationAddress { get; init; }

        /// <summary>
        /// Additional regulatory information about the investor or account owner that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_VOd8lVxkEeWvPv3PXpS3fw")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; }

        /// <summary>
        /// Specifies if the account party is regarded as domestic or non-domestic for reporting purposes.
        /// </summary>
        [IsoId("_66698YkeEeWFCoSYeBm65Q")]
        [DisplayName("Accounting Status")]
        [IsoXmlTag("AcctgSts")]
        public AccountingStatus1Choice_? AccountingStatus { get; init; }

        /// <summary>
        /// Additional information concerning limitations and restrictions on the account party.
        /// </summary>
        [IsoId("_zw8OEYkfEeWFCoSYeBm65Q")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AccountRestrictions1? AdditionalInformation { get; init; }
    }
}
