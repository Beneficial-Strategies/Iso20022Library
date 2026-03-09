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
namespace BeneficialStrategies.Iso20022.Choices.AccountParties9Choice
{
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_PfIHmSCBEeWhHbfCMWc1cw")]
    [DisplayName("Nominee")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Nominee : AccountParties9Choice_
    #else
    public partial class Nominee : AccountParties9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Nominee instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Nominee( Party30Choice_ reqParty )
        {
            Party = reqParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information about the organisation or individual person.
        /// </summary>
        [IsoId("_Nv_sQyCBEeWhHbfCMWc1cw")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty")]
        #endif
        [IsoXmlTag("Pty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Party30Choice_ Party { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Party30Choice_ Party { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party30Choice_ Party { get; init; } 
        #else
        public Party30Choice_ Party { get; set; } 
        #endif
        
        /// <summary>
        /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
        /// </summary>
        [IsoId("_Nv_sRSCBEeWhHbfCMWc1cw")]
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
        /// Information related to the party profile to be inserted or deleted.
        /// </summary>
        [IsoId("_Nv_sTyCBEeWhHbfCMWc1cw")]
        [DisplayName("Modified Investor Profile Validation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ModfdInvstrPrflVldtn")]
        #endif
        [IsoXmlTag("ModfdInvstrPrflVldtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ModificationScope27? ModifiedInvestorProfileValidation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ModificationScope27? ModifiedInvestorProfileValidation { get; init; } 
        #else
        public ModificationScope27? ModifiedInvestorProfileValidation { get; set; } 
        #endif
        
        /// <summary>
        /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions or purchases and or redemptions or sells will be allocated using the same percentage.
        /// </summary>
        [IsoId("_Nv_sRyCBEeWhHbfCMWc1cw")]
        [DisplayName("Ownership Beneficiary Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OwnrshBnfcryRate")]
        #endif
        [IsoXmlTag("OwnrshBnfcryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? OwnershipBeneficiaryRate { get; init; } 
        #else
        public System.Decimal? OwnershipBeneficiaryRate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
        /// </summary>
        [IsoId("_Nv_sSSCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sSyCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sTSCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sUSCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sUyCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sVSCBEeWhHbfCMWc1cw")]
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
        [IsoId("_Nv_sVyCBEeWhHbfCMWc1cw")]
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
        /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_lNqiuyCkEeWJd9HF2tO7BA")]
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
        [IsoId("_VZegYYkfEeWFCoSYeBm65Q")]
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
        [IsoId("_lNqivCCkEeWJd9HF2tO7BA")]
        [DisplayName("Tax Reporting")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxRptg")]
        #endif
        [IsoXmlTag("TaxRptg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxReporting1? TaxReporting { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxReporting1? TaxReporting { get; init; } 
        #else
        public TaxReporting1? TaxReporting { get; set; } 
        #endif
        
        /// <summary>
        /// Language in which the organisation or person communicates.
        /// </summary>
        [IsoId("_lNqivSCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqiwCCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqiwSCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqiwiCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqiwyCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqixCCkEeWJd9HF2tO7BA")]
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
        [IsoId("_lNqixSCkEeWJd9HF2tO7BA")]
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
        [IsoId("_vcrh4SFIEeWgV9SQSyaAog")]
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
        [IsoId("_X0XAw1xkEeWvPv3PXpS3fw")]
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
        [IsoId("_X0XAxFxkEeWvPv3PXpS3fw")]
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
        [IsoId("_X0XAxVxkEeWvPv3PXpS3fw")]
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
        [IsoId("_anxxQYkfEeWFCoSYeBm65Q")]
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
        /// Additional information concerning limitations and restrictions on the account party.
        /// </summary>
        [IsoId("_6Ea-UYkfEeWFCoSYeBm65Q")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountRestrictions1? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountRestrictions1? AdditionalInformation { get; init; } 
        #else
        public AccountRestrictions1? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
