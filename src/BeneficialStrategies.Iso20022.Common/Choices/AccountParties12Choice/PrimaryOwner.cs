// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountParties12Choice
{
    /// <summary>
    /// Single owner of the account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_mp9DUZQ_EemqYPWMBuVawg")]
    [DisplayName("Primary Owner")]
    public record PrimaryOwner : AccountParties12Choice_
    {
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_lvVOIZQ_EemqYPWMBuVawg")]
        [DisplayName("Party")]
        [IsoXmlTag("Pty")]
        public required Party47Choice_ Party { get; init; }

        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_lvVOI5Q_EemqYPWMBuVawg")]
        [DisplayName("Money Laundering Check")]
        [IsoXmlTag("MnyLndrgChck")]
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; }

        /// <summary>
        /// Information to support Know Your Customer (KYC) processes.
        /// </summary>
        [IsoId("_lvVOJZQ_EemqYPWMBuVawg")]
        [DisplayName("Investor Profile Validation")]
        [IsoXmlTag("InvstrPrflVldtn")]
        public PartyProfileInformation5? InvestorProfileValidation { get; init; }

        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
        /// </summary>
        [IsoId("_lvVOJ5Q_EemqYPWMBuVawg")]
        [DisplayName("Ownership Beneficiary Rate")]
        [IsoXmlTag("OwnrshBnfcryRate")]
        public OwnershipBeneficiaryRate1? OwnershipBeneficiaryRate { get; init; }

        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_lvVOKZQ_EemqYPWMBuVawg")]
        [DisplayName("Client Identification")]
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientIdentification { get; init; }

        /// <summary>
        /// Indicates whether an owner of the account may benefit from a fiscal exemption or amnesty, for example, when declaring overseas investments.
        /// </summary>
        [IsoId("_lvVOK5Q_EemqYPWMBuVawg")]
        [DisplayName("Fiscal Exemption")]
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? FiscalExemption { get; init; }

        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_lvVOLZQ_EemqYPWMBuVawg")]
        [DisplayName("Signatory Right Indicator")]
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; }

        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_lvVOL5Q_EemqYPWMBuVawg")]
        [DisplayName("Mi FID Classification")]
        [IsoXmlTag("MiFIDClssfctn")]
        public MiFIDClassification1? MiFIDClassification { get; init; }

        /// <summary>
        /// Type of information that must be provided to the account holder.
        /// </summary>
        [IsoId("_lvVOMZQ_EemqYPWMBuVawg")]
        [DisplayName("Notification")]
        [IsoXmlTag("Ntfctn")]
        public Notification2? Notification { get; init; }

        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor or account owner.
        /// </summary>
        [IsoId("_lvVOM5Q_EemqYPWMBuVawg")]
        [DisplayName("FATCA Form Type")]
        [IsoXmlTag("FATCAFormTp")]
        public FATCAForm1Choice_? FATCAFormType { get; init; }

        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor or account owner.
        /// </summary>
        [IsoId("_lvVONZQ_EemqYPWMBuVawg")]
        [DisplayName("FATCA Status")]
        [IsoXmlTag("FATCASts")]
        public FATCAStatus2? FATCAStatus { get; init; }

        /// <summary>
        /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
        /// </summary>
        [IsoId("_lvVON5Q_EemqYPWMBuVawg")]
        [DisplayName("FATCA Reporting Date")]
        [IsoXmlTag("FATCARptgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FATCAReportingDate { get; init; }

        /// <summary>
        /// Type of Common Reporting Standard (CRS) form submitted by the investor or account owner.
        /// </summary>
        [IsoId("_lvVOOZQ_EemqYPWMBuVawg")]
        [DisplayName("CRS Form Type")]
        [IsoXmlTag("CRSFormTp")]
        public CRSForm1Choice_? CRSFormType { get; init; }

        /// <summary>
        /// Common Reporting Standard (CRS) status of the investor or account owner.
        /// </summary>
        [IsoId("_lvVOO5Q_EemqYPWMBuVawg")]
        [DisplayName("CRS Status")]
        [IsoXmlTag("CRSSts")]
        public CRSStatus4? CRSStatus { get; init; }

        /// <summary>
        /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
        /// </summary>
        [IsoId("_lvVOPZQ_EemqYPWMBuVawg")]
        [DisplayName("CRS Reporting Date")]
        [IsoXmlTag("CRSRptgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? CRSReportingDate { get; init; }

        /// <summary>
        /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_lvVOP5Q_EemqYPWMBuVawg")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        public GenericIdentification82? OtherIdentification { get; init; }

        /// <summary>
        /// Tax advantage specific to the account party.
        /// </summary>
        [IsoId("_lvVOQZQ_EemqYPWMBuVawg")]
        [DisplayName("Tax Exemption")]
        [IsoXmlTag("TaxXmptn")]
        public TaxExemptionReason2Choice_? TaxExemption { get; init; }

        /// <summary>
        /// Details for the reporting of tax, for example, the country of taxation.
        /// </summary>
        [IsoId("_lvVOQ5Q_EemqYPWMBuVawg")]
        [DisplayName("Tax Reporting")]
        [IsoXmlTag("TaxRptg")]
        public TaxReporting3? TaxReporting { get; init; }

        /// <summary>
        /// Language in which the organisation or person communicates.
        /// </summary>
        [IsoId("_lvVORZQ_EemqYPWMBuVawg")]
        [DisplayName("Language")]
        [IsoXmlTag("Lang")]
        public LanguageCode? Language { get; init; }

        /// <summary>
        /// Method used for postal mailing.
        /// </summary>
        [IsoId("_lvVOSZQ_EemqYPWMBuVawg")]
        [DisplayName("Mail Type")]
        [IsoXmlTag("MailTp")]
        public MailType1Choice_? MailType { get; init; }

        /// <summary>
        /// Country and residential status of the organisation or individual person.
        /// </summary>
        [IsoId("_lvVOS5Q_EemqYPWMBuVawg")]
        [DisplayName("Country And Residential Status")]
        [IsoXmlTag("CtryAndResdtlSts")]
        public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; }

        /// <summary>
        /// Annual wealth of the individual person or share capital value of the legal entity and date on which the annual wealth of the individual person was registered or declared or the date the stock value of the organisation was registered.
        /// </summary>
        [IsoId("_lvVOTZQ_EemqYPWMBuVawg")]
        [DisplayName("Monetary Wealth")]
        [IsoXmlTag("MntryWlth")]
        public DateAndAmount1? MonetaryWealth { get; init; }

        /// <summary>
        /// Amount of total assets minus liabilities of the individual person or the amount of the difference between assets and liabilities plus rights over obligations (net equity) of the organisation and the date on which the equity value was registered.
        /// </summary>
        [IsoId("_lvVOT5Q_EemqYPWMBuVawg")]
        [DisplayName("Equity Value")]
        [IsoXmlTag("EqtyVal")]
        public DateAndAmount1? EquityValue { get; init; }

        /// <summary>
        /// Resource or value owned or used by a third-party company and the date on which the working capital amount was registered.
        /// </summary>
        [IsoId("_lvVOUZQ_EemqYPWMBuVawg")]
        [DisplayName("Working Capital")]
        [IsoXmlTag("WorkgCptl")]
        public DateAndAmount1? WorkingCapital { get; init; }

        /// <summary>
        /// Account owner&apos;s connection with the trading party or broker.
        /// </summary>
        [IsoId("_lvVOU5Q_EemqYPWMBuVawg")]
        [DisplayName("Company Link")]
        [IsoXmlTag("CpnyLk")]
        public CompanyLink1Choice_? CompanyLink { get; init; }

        /// <summary>
        /// Reference to be specified when a letter, for example, an order confirmation, is sent by an automated mailing system.
        /// </summary>
        [IsoId("_lvVOVZQ_EemqYPWMBuVawg")]
        [DisplayName("Electronic Mailing Service Reference")]
        [IsoXmlTag("ElctrncMlngSvcRef")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? ElectronicMailingServiceReference { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_lvVOV5Q_EemqYPWMBuVawg")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress6? PrimaryCommunicationAddress { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_lvVOWZQ_EemqYPWMBuVawg")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress6? SecondaryCommunicationAddress { get; init; }

        /// <summary>
        /// Additional regulatory information about the investor or account owner that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_lvVOW5Q_EemqYPWMBuVawg")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; }

        /// <summary>
        /// Specifies if the account party is regarded as domestic or non-domestic for reporting purposes.
        /// </summary>
        [IsoId("_lvVOXZQ_EemqYPWMBuVawg")]
        [DisplayName("Accounting Status")]
        [IsoXmlTag("AcctgSts")]
        public AccountingStatus1Choice_? AccountingStatus { get; init; }

        /// <summary>
        /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
        /// </summary>
        [IsoId("_lvVOX5Q_EemqYPWMBuVawg")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditiononalInformation13? AdditionalInformation { get; init; }

        /// <summary>
        /// Party is the controlling person.
        /// (For an Entity that is a legal person, the term “Controlling Persons” means the natural person(s) who exercises control over the Entity. “Control” over an Entity is generally exercised by the natural person(s) who ultimately has a controlling ownership interest in the Entity. A “control ownership interest” depends on the ownership structure of the legal person and is usually identified on the basis of a threshold applying a risk-based approach (e.g. any person(s) owning more than a certain percentage of the legal person, such as 25%). Where no natural person(s) exercises control through ownership interests, the Controlling Person(s) of the Entity will be the natural person(s) who exercises control of the Entity through other means. Where no natural person(s) is identified as exercising control of the Entity, the Controlling Person(s) of the Entity will be the natural person(s) who holds the position of senior managing official.).
        /// </summary>
        [IsoId("_lvVOYZQ_EemqYPWMBuVawg")]
        [DisplayName("Controlling Party")]
        [IsoXmlTag("CtrlgPty")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ControllingParty { get; init; }
    }
}
