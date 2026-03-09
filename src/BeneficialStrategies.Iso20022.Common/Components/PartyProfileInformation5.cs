// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to support the Know Your Customer (KYC) processes.
/// </summary>
[IsoId("_HEMRASGREeWO8_xZKx-MFg")]
[DisplayName("Party Profile Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyProfileInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the certificate type has been obtained and verified.
    /// </summary>
    [IsoId("_HgwRMSGREeWO8_xZKx-MFg")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIndicator { get; init; } 
    #else
    public System.String? CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who validated the document.
    /// </summary>
    [IsoId("_HgwRMyGREeWO8_xZKx-MFg")]
    [DisplayName("Validating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtngPty")]
    #endif
    [IsoXmlTag("VldtngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ValidatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidatingParty { get; init; } 
    #else
    public System.String? ValidatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who checked the document.
    /// </summary>
    [IsoId("_HgwRNSGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngPty")]
    #endif
    [IsoXmlTag("ChckngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CheckingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckingParty { get; init; } 
    #else
    public System.String? CheckingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who is responsible for the document.
    /// </summary>
    [IsoId("_HgwRNyGREeWO8_xZKx-MFg")]
    [DisplayName("Responsible Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPty")]
    #endif
    [IsoXmlTag("RspnsblPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ResponsibleParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponsibleParty { get; init; } 
    #else
    public System.String? ResponsibleParty { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certificate.
    /// </summary>
    [IsoId("_HgwROSGREeWO8_xZKx-MFg")]
    [DisplayName("Certificate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertTp")]
    #endif
    [IsoXmlTag("CertTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificationType1Choice_? CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificationType1Choice_? CertificateType { get; init; } 
    #else
    public CertificationType1Choice_? CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the certification check has been performed.
    /// </summary>
    [IsoId("_HgwROyGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngDt")]
    #endif
    [IsoXmlTag("ChckngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckingDate { get; init; } 
    #else
    public System.DateOnly? CheckingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how frequently the check is performed.
    /// </summary>
    [IsoId("_HgwRPSGREeWO8_xZKx-MFg")]
    [DisplayName("Checking Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngFrqcy")]
    #endif
    [IsoXmlTag("ChckngFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency1Code? CheckingFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency1Code? CheckingFrequency { get; init; } 
    #else
    public EventFrequency1Code? CheckingFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date at which the next certification check will be performed.
    /// </summary>
    [IsoId("_HgwRPyGREeWO8_xZKx-MFg")]
    [DisplayName("Next Revision Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtRvsnDt")]
    #endif
    [IsoXmlTag("NxtRvsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextRevisionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextRevisionDate { get; init; } 
    #else
    public System.DateOnly? NextRevisionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Limits between which a person&apos;s salary is estimated.
    /// </summary>
    [IsoId("_HgwRQSGREeWO8_xZKx-MFg")]
    [DisplayName("Salary Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlryRg")]
    #endif
    [IsoXmlTag("SlryRg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SalaryRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SalaryRange { get; init; } 
    #else
    public System.String? SalaryRange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the main source of revenue.
    /// </summary>
    [IsoId("_HgwRQyGREeWO8_xZKx-MFg")]
    [DisplayName("Source Of Wealth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfWlth")]
    #endif
    [IsoXmlTag("SrcOfWlth")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SourceOfWealth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SourceOfWealth { get; init; } 
    #else
    public System.String? SourceOfWealth { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_HgwRRSGREeWO8_xZKx-MFg")]
    [DisplayName("Customer Conduct Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrCndctClssfctn")]
    #endif
    [IsoXmlTag("CstmrCndctClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    #else
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the customer’s money laundering risk.
    /// </summary>
    [IsoId("_Hg5bISGREeWO8_xZKx-MFg")]
    [DisplayName("Risk Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskLvl")]
    #endif
    [IsoXmlTag("RskLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskLevel2Choice_? RiskLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskLevel2Choice_? RiskLevel { get; init; } 
    #else
    public RiskLevel2Choice_? RiskLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of due diligence checks carried out on the investor or account owner. For definitions of ordinary, simple and enhanced know your customer checks, local market regulations should be consulted.
    /// </summary>
    [IsoId("_Hg5bIyGREeWO8_xZKx-MFg")]
    [DisplayName("Know Your Customer Check Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KnowYourCstmrChckTp")]
    #endif
    [IsoXmlTag("KnowYourCstmrChckTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KYCCheckType1Choice_? KnowYourCustomerCheckType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KYCCheckType1Choice_? KnowYourCustomerCheckType { get; init; } 
    #else
    public KYCCheckType1Choice_? KnowYourCustomerCheckType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether a customer has been checked in a Know Your Customer (KYC) database.
    /// </summary>
    [IsoId("_Hg5bJSGREeWO8_xZKx-MFg")]
    [DisplayName("Know Your Customer Database Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KnowYourCstmrDBChck")]
    #endif
    [IsoXmlTag("KnowYourCstmrDBChck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataBaseCheck1? KnowYourCustomerDatabaseCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataBaseCheck1? KnowYourCustomerDatabaseCheck { get; init; } 
    #else
    public DataBaseCheck1? KnowYourCustomerDatabaseCheck { get; set; } 
    #endif
    
    
    #nullable disable
    
}
