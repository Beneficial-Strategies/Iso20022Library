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
/// Criteria for a query about securities reference data.
/// </summary>
[IsoId("_QETUpZJKEeuAlLVx8pyt3w")]
[DisplayName("Securities Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSearchCriteria4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_QGUG0ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification39? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_QGUG05JKEeuAlLVx8pyt3w")]
    [DisplayName("Classification Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnFinInstrm")]
    #endif
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassificationFinancialInstrument { get; init; } 
    #else
    public System.String? ClassificationFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_QGUG1ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? MaturityDate { get; init; } 
    #else
    public DatePeriodSearch1Choice_? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_QGUG6ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? IssueDate { get; init; } 
    #else
    public DatePeriodSearch1Choice_? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_QGUG65JKEeuAlLVx8pyt3w")]
    [DisplayName("Issue Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseCcy")]
    #endif
    [IsoXmlTag("IsseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? IssueCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? IssueCurrency { get; init; } 
    #else
    public string? IssueCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_QGUG85JKEeuAlLVx8pyt3w")]
    [DisplayName("Country Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIsse")]
    #endif
    [IsoXmlTag("CtryOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIssue { get; init; } 
    #else
    public string? CountryOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_QGUG-5JKEeuAlLVx8pyt3w")]
    [DisplayName("Security Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctySts")]
    #endif
    [IsoXmlTag("SctySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    #else
    public SecurityStatus3Choice_? SecurityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHA5JKEeuAlLVx8pyt3w")]
    [DisplayName("Maintaining CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntngCSD")]
    #endif
    [IsoXmlTag("MntngCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? MaintainingCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? MaintainingCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? MaintainingCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHBZJKEeuAlLVx8pyt3w")]
    [DisplayName("Investor CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrCSD")]
    #endif
    [IsoXmlTag("InvstrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? InvestorCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHB5JKEeuAlLVx8pyt3w")]
    [DisplayName("Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCSD")]
    #endif
    [IsoXmlTag("IssrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? IssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_QGUHCZJKEeuAlLVx8pyt3w")]
    [DisplayName("Technical Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechIssrCSD")]
    #endif
    [IsoXmlTag("TechIssrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// CSD of a security.
    /// </summary>
    [IsoId("_QGUHC5JKEeuAlLVx8pyt3w")]
    [DisplayName("CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSD")]
    #endif
    [IsoXmlTag("CSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? CSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? CSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? CSD { get; set; } 
    #endif
    
    
    #nullable disable
    
}
