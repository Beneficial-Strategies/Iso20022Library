// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.AccountParties10Choice
{
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_xFUDJ0NMEeamLdeYEZm56w")]
    [DisplayName("Joint Owner")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record JointOwner : AccountParties10Choice_
    #else
    public partial class JointOwner : AccountParties10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a JointOwner instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public JointOwner( Party32Choice_ reqParty )
        {
            Party = reqParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_v6xioUNMEeamLdeYEZm56w")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty")]
        #endif
        [IsoXmlTag("Pty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Party32Choice_ Party { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Party32Choice_ Party { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party32Choice_ Party { get; init; } 
        #else
        public Party32Choice_ Party { get; set; } 
        #endif
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_v6xio0NMEeamLdeYEZm56w")]
        [DisplayName("Money Laundering Check")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MnyLndrgChck")]
        #endif
        [IsoXmlTag("MnyLndrgChck")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; init; } 
        #else
        public MoneyLaunderingCheck1Choice_? MoneyLaunderingCheck { get; set; } 
        #endif
        
        /// <summary>
        /// Information to support Know Your Customer (KYC) processes.
        /// </summary>
        [IsoId("_v6xipUNMEeamLdeYEZm56w")]
        [DisplayName("Investor Profile Validation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstrPrflVldtn")]
        #endif
        [IsoXmlTag("InvstrPrflVldtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyProfileInformation5? InvestorProfileValidation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyProfileInformation5? InvestorProfileValidation { get; init; } 
        #else
        public PartyProfileInformation5? InvestorProfileValidation { get; set; } 
        #endif
        
        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
        /// </summary>
        [IsoId("_v6xip0NMEeamLdeYEZm56w")]
        [DisplayName("Ownership Beneficiary Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OwnrshBnfcryRate")]
        #endif
        [IsoXmlTag("OwnrshBnfcryRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OwnershipBeneficiaryRate1? OwnershipBeneficiaryRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OwnershipBeneficiaryRate1? OwnershipBeneficiaryRate { get; init; } 
        #else
        public OwnershipBeneficiaryRate1? OwnershipBeneficiaryRate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_v6xiqUNMEeamLdeYEZm56w")]
        [DisplayName("Client Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClntId")]
        #endif
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ClientIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClientIdentification { get; init; } 
        #else
        public System.String? ClientIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether an owner of the account may benefit from a fiscal exemption or amnesty, for example, when declaring overseas investments.
        /// </summary>
        [IsoId("_v6xiq0NMEeamLdeYEZm56w")]
        [DisplayName("Fiscal Exemption")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FsclXmptn")]
        #endif
        [IsoXmlTag("FsclXmptn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? FiscalExemption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? FiscalExemption { get; init; } 
        #else
        public System.String? FiscalExemption { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
        /// </summary>
        [IsoId("_v6xirUNMEeamLdeYEZm56w")]
        [DisplayName("Signatory Right Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgntryRghtInd")]
        #endif
        [IsoXmlTag("SgntryRghtInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SignatoryRightIndicator { get; init; } 
        #else
        public System.String? SignatoryRightIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Details about the MiFID classification of the account owner.
        /// </summary>
        [IsoId("_v6xir0NMEeamLdeYEZm56w")]
        [DisplayName("Mi FID Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MiFIDClssfctn")]
        #endif
        [IsoXmlTag("MiFIDClssfctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MiFIDClassification1? MiFIDClassification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MiFIDClassification1? MiFIDClassification { get; init; } 
        #else
        public MiFIDClassification1? MiFIDClassification { get; set; } 
        #endif
        
        /// <summary>
        /// Type of information that must be provided to the account holder.
        /// </summary>
        [IsoId("_v6xisUNMEeamLdeYEZm56w")]
        [DisplayName("Notification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ntfctn")]
        #endif
        [IsoXmlTag("Ntfctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Notification2? Notification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Notification2? Notification { get; init; } 
        #else
        public Notification2? Notification { get; set; } 
        #endif
        
        /// <summary>
        /// Type of Foreign Account Tax Compliance Act (FATCA) form submitted by the investor or account owner.
        /// </summary>
        [IsoId("_v6xis0NMEeamLdeYEZm56w")]
        [DisplayName("FATCA Form Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FATCAFormTp")]
        #endif
        [IsoXmlTag("FATCAFormTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FATCAForm1Choice_? FATCAFormType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FATCAForm1Choice_? FATCAFormType { get; init; } 
        #else
        public FATCAForm1Choice_? FATCAFormType { get; set; } 
        #endif
        
        /// <summary>
        /// Foreign Account Tax Compliance Act (FATCA) status of the investor or account owner.
        /// </summary>
        [IsoId("_v6xitUNMEeamLdeYEZm56w")]
        [DisplayName("FATCA Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FATCASts")]
        #endif
        [IsoXmlTag("FATCASts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FATCAStatus2? FATCAStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FATCAStatus2? FATCAStatus { get; init; } 
        #else
        public FATCAStatus2? FATCAStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
        /// </summary>
        [IsoId("_gK8zkGBzEeaHEJD5P6-ccw")]
        [DisplayName("FATCA Reporting Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FATCARptgDt")]
        #endif
        [IsoXmlTag("FATCARptgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? FATCAReportingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? FATCAReportingDate { get; init; } 
        #else
        public System.DateOnly? FATCAReportingDate { get; set; } 
        #endif
        
        /// <summary>
        /// Type of Common Reporting Standard (CRS) form submitted by the investor or account owner.
        /// </summary>
        [IsoId("_VJSksUNuEeaS-NnwLNvMPg")]
        [DisplayName("CRS Form Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CRSFormTp")]
        #endif
        [IsoXmlTag("CRSFormTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CRSForm1Choice_? CRSFormType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CRSForm1Choice_? CRSFormType { get; init; } 
        #else
        public CRSForm1Choice_? CRSFormType { get; set; } 
        #endif
        
        /// <summary>
        /// Common Reporting Standard (CRS) status of the investor or account owner.
        /// </summary>
        [IsoId("_fdnugENeEeamLdeYEZm56w")]
        [DisplayName("CRS Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CRSSts")]
        #endif
        [IsoXmlTag("CRSSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CRSStatus4? CRSStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CRSStatus4? CRSStatus { get; init; } 
        #else
        public CRSStatus4? CRSStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
        /// </summary>
        [IsoId("_kdKrYXXXEeaH0fB6yD0LBA")]
        [DisplayName("CRS Reporting Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CRSRptgDt")]
        #endif
        [IsoXmlTag("CRSRptgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? CRSReportingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? CRSReportingDate { get; init; } 
        #else
        public System.DateOnly? CRSReportingDate { get; set; } 
        #endif
        
        /// <summary>
        /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_v6xit0NMEeamLdeYEZm56w")]
        [DisplayName("Other Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrId")]
        #endif
        [IsoXmlTag("OthrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericIdentification82? OtherIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification82? OtherIdentification { get; init; } 
        #else
        public GenericIdentification82? OtherIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Tax advantage specific to the account party.
        /// </summary>
        [IsoId("_v6xiuUNMEeamLdeYEZm56w")]
        [DisplayName("Tax Exemption")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxXmptn")]
        #endif
        [IsoXmlTag("TaxXmptn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxExemptionReason2Choice_? TaxExemption { get; init; } 
        #else
        public TaxExemptionReason2Choice_? TaxExemption { get; set; } 
        #endif
        
        /// <summary>
        /// Details for the reporting of tax, for example, the country of taxation.
        /// </summary>
        [IsoId("_v6xiu0NMEeamLdeYEZm56w")]
        [DisplayName("Tax Reporting")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxRptg")]
        #endif
        [IsoXmlTag("TaxRptg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxReporting2? TaxReporting { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxReporting2? TaxReporting { get; init; } 
        #else
        public TaxReporting2? TaxReporting { get; set; } 
        #endif
        
        /// <summary>
        /// Language in which the organisation or person communicates.
        /// </summary>
        [IsoId("_v6xivUNMEeamLdeYEZm56w")]
        [DisplayName("Language")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lang")]
        #endif
        [IsoXmlTag("Lang")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LanguageCode? Language { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? Language { get; init; } 
        #else
        public string? Language { get; set; } 
        #endif
        
        /// <summary>
        /// Method used for postal mailing.
        /// </summary>
        [IsoId("_v6xiwUNMEeamLdeYEZm56w")]
        [DisplayName("Mail Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MailTp")]
        #endif
        [IsoXmlTag("MailTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MailType1Choice_? MailType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MailType1Choice_? MailType { get; init; } 
        #else
        public MailType1Choice_? MailType { get; set; } 
        #endif
        
        /// <summary>
        /// Country and residential status of the organisation or individual person.
        /// </summary>
        [IsoId("_v6xiw0NMEeamLdeYEZm56w")]
        [DisplayName("Country And Residential Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtryAndResdtlSts")]
        #endif
        [IsoXmlTag("CtryAndResdtlSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; } 
        #else
        public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Annual wealth of the individual person or share capital value of the legal entity and date on which the annual wealth of the individual person was registered or declared or the date the stock value of the organisation was registered.
        /// </summary>
        [IsoId("_v6xixUNMEeamLdeYEZm56w")]
        [DisplayName("Monetary Wealth")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MntryWlth")]
        #endif
        [IsoXmlTag("MntryWlth")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndAmount1? MonetaryWealth { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndAmount1? MonetaryWealth { get; init; } 
        #else
        public DateAndAmount1? MonetaryWealth { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of total assets minus liabilities of the individual person or the amount of the difference between assets and liabilities plus rights over obligations (net equity) of the organisation and the date on which the equity value was registered.
        /// </summary>
        [IsoId("_v6xix0NMEeamLdeYEZm56w")]
        [DisplayName("Equity Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EqtyVal")]
        #endif
        [IsoXmlTag("EqtyVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndAmount1? EquityValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndAmount1? EquityValue { get; init; } 
        #else
        public DateAndAmount1? EquityValue { get; set; } 
        #endif
        
        /// <summary>
        /// Resource or value owned or used by a third-party company and the date on which the working capital amount was registered.
        /// </summary>
        [IsoId("_v6xiyUNMEeamLdeYEZm56w")]
        [DisplayName("Working Capital")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="WorkgCptl")]
        #endif
        [IsoXmlTag("WorkgCptl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndAmount1? WorkingCapital { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndAmount1? WorkingCapital { get; init; } 
        #else
        public DateAndAmount1? WorkingCapital { get; set; } 
        #endif
        
        /// <summary>
        /// Account owner&apos;s connection with the trading party or broker.
        /// </summary>
        [IsoId("_v6xiy0NMEeamLdeYEZm56w")]
        [DisplayName("Company Link")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CpnyLk")]
        #endif
        [IsoXmlTag("CpnyLk")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompanyLink1Choice_? CompanyLink { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompanyLink1Choice_? CompanyLink { get; init; } 
        #else
        public CompanyLink1Choice_? CompanyLink { get; set; } 
        #endif
        
        /// <summary>
        /// Reference to be specified when a letter (for example, an order confirmation) is sent by an automated mailing system.
        /// </summary>
        [IsoId("_v6xizUNMEeamLdeYEZm56w")]
        [DisplayName("Electronic Mailing Service Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ElctrncMlngSvcRef")]
        #endif
        [IsoXmlTag("ElctrncMlngSvcRef")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? ElectronicMailingServiceReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ElectronicMailingServiceReference { get; init; } 
        #else
        public System.String? ElectronicMailingServiceReference { get; set; } 
        #endif
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_v6xiz0NMEeamLdeYEZm56w")]
        [DisplayName("Primary Communication Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmryComAdr")]
        #endif
        [IsoXmlTag("PmryComAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress6? PrimaryCommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress6? PrimaryCommunicationAddress { get; init; } 
        #else
        public CommunicationAddress6? PrimaryCommunicationAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_v6xi0UNMEeamLdeYEZm56w")]
        [DisplayName("Secondary Communication Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ScndryComAdr")]
        #endif
        [IsoXmlTag("ScndryComAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress6? SecondaryCommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress6? SecondaryCommunicationAddress { get; init; } 
        #else
        public CommunicationAddress6? SecondaryCommunicationAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Additional regulatory information about the investor or account owner that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_v6xi00NMEeamLdeYEZm56w")]
        [DisplayName("Additional Regulatory Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRgltryInf")]
        #endif
        [IsoXmlTag("AddtlRgltryInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        #else
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies if the account party is regarded as domestic or non-domestic for reporting purposes.
        /// </summary>
        [IsoId("_v6xi1UNMEeamLdeYEZm56w")]
        [DisplayName("Accounting Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctgSts")]
        #endif
        [IsoXmlTag("AcctgSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountingStatus1Choice_? AccountingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountingStatus1Choice_? AccountingStatus { get; init; } 
        #else
        public AccountingStatus1Choice_? AccountingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
        /// </summary>
        [IsoId("_v6xi10NMEeamLdeYEZm56w")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditiononalInformation12? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditiononalInformation12? AdditionalInformation { get; init; } 
        #else
        public AdditiononalInformation12? AdditionalInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Party is the controlling person. 
        /// (For an Entity that is a legal person, the term “Controlling Persons” means the natural person(s) who exercises control over the Entity. “Control” over an Entity is generally exercised by the natural person(s) who ultimately has a controlling ownership interest in the Entity. A “control ownership interest” depends on the ownership structure of the legal person and is usually identified on the basis of a threshold applying a risk-based approach (e.g. any person(s) owning more than a certain percentage of the legal person, such as 25%). Where no natural person(s) exercises control through ownership interests, the Controlling Person(s) of the Entity will be the natural person(s) who exercises control of the Entity through other means. Where no natural person(s) is identified as exercising control of the Entity, the Controlling Person(s) of the Entity will be the natural person(s) who holds the position of senior managing official.).
        /// </summary>
        [IsoId("_esEVYUzYEea8fovz_9xSTQ")]
        [DisplayName("Controlling Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrlgPty")]
        #endif
        [IsoXmlTag("CtrlgPty")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? ControllingParty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ControllingParty { get; init; } 
        #else
        public System.String? ControllingParty { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
