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
/// Return criteria for information to be returned in the report deriving from a query about securities reference data.
/// </summary>
[IsoId("_hXQrSWliEeGaMcKyqKNRfQ_-1281740246")]
[DisplayName("Securities Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesReturnCriteria1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesReturnCriteria1( System.String reqFinancialInstrumentIdentification,System.String reqISOSecurityLongName,System.String reqISOSecurityShortName,System.String reqClassificationFinancialInstrument,System.String reqMaturityDate,System.String reqIssueDate,System.String reqIssueCurrency,System.String reqCountryOfIssue,System.String reqSecurityStatus,System.String reqInvestorCSD,System.String reqIssuerCSD,System.String reqTechnicalIssuerCSD,System.String reqCSD,System.String reqSecuritiesQuantityType,System.String reqMinimumDenomination,System.String reqMinimumMultipleQuantity,System.String reqDeviatingSettlementUnit )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        ISOSecurityLongName = reqISOSecurityLongName;
        ISOSecurityShortName = reqISOSecurityShortName;
        ClassificationFinancialInstrument = reqClassificationFinancialInstrument;
        MaturityDate = reqMaturityDate;
        IssueDate = reqIssueDate;
        IssueCurrency = reqIssueCurrency;
        CountryOfIssue = reqCountryOfIssue;
        SecurityStatus = reqSecurityStatus;
        InvestorCSD = reqInvestorCSD;
        IssuerCSD = reqIssuerCSD;
        TechnicalIssuerCSD = reqTechnicalIssuerCSD;
        CSD = reqCSD;
        SecuritiesQuantityType = reqSecuritiesQuantityType;
        MinimumDenomination = reqMinimumDenomination;
        MinimumMultipleQuantity = reqMinimumMultipleQuantity;
        DeviatingSettlementUnit = reqDeviatingSettlementUnit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_hXQrSmliEeGaMcKyqKNRfQ_1355658104")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FinancialInstrumentIdentification { get; init; } 
    #else
    public System.String FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_hXQrS2liEeGaMcKyqKNRfQ_2109594347")]
    [DisplayName("ISO Security Long Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOSctyLngNm")]
    #endif
    [IsoXmlTag("ISOSctyLngNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator ISOSecurityLongName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISOSecurityLongName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISOSecurityLongName { get; init; } 
    #else
    public System.String ISOSecurityLongName { get; set; } 
    #endif
    
    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_hXQrTGliEeGaMcKyqKNRfQ_1698752525")]
    [DisplayName("ISO Security Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOSctyShrtNm")]
    #endif
    [IsoXmlTag("ISOSctyShrtNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator ISOSecurityShortName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISOSecurityShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISOSecurityShortName { get; init; } 
    #else
    public System.String ISOSecurityShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_hXQrTWliEeGaMcKyqKNRfQ_-1867260926")]
    [DisplayName("Classification Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnFinInstrm")]
    #endif
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator ClassificationFinancialInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClassificationFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClassificationFinancialInstrument { get; init; } 
    #else
    public System.String ClassificationFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_hXQrTmliEeGaMcKyqKNRfQ_1997846748")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator MaturityDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MaturityDate { get; init; } 
    #else
    public System.String MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_hXQrT2liEeGaMcKyqKNRfQ_-847027990")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssueDate { get; init; } 
    #else
    public System.String IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_hXQrUGliEeGaMcKyqKNRfQ_-270251885")]
    [DisplayName("Issue Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseCcy")]
    #endif
    [IsoXmlTag("IsseCcy")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator IssueCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssueCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssueCurrency { get; init; } 
    #else
    public System.String IssueCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_hXQrUWliEeGaMcKyqKNRfQ_812960440")]
    [DisplayName("Country Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIsse")]
    #endif
    [IsoXmlTag("CtryOfIsse")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator CountryOfIssue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CountryOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CountryOfIssue { get; init; } 
    #else
    public System.String CountryOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_hXQrUmliEeGaMcKyqKNRfQ_-876696833")]
    [DisplayName("Security Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctySts")]
    #endif
    [IsoXmlTag("SctySts")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator SecurityStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecurityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecurityStatus { get; init; } 
    #else
    public System.String SecurityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// CSD Investor of a security.
    /// </summary>
    [IsoId("_hXQrU2liEeGaMcKyqKNRfQ_-1284010832")]
    [DisplayName("Investor CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrCSD")]
    #endif
    [IsoXmlTag("InvstrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator InvestorCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InvestorCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestorCSD { get; init; } 
    #else
    public System.String InvestorCSD { get; set; } 
    #endif
    
    /// <summary>
    /// CSD Issuer of a security.
    /// </summary>
    [IsoId("_hXQrVGliEeGaMcKyqKNRfQ_361256603")]
    [DisplayName("Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCSD")]
    #endif
    [IsoXmlTag("IssrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator IssuerCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerCSD { get; init; } 
    #else
    public System.String IssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_hXQrVWliEeGaMcKyqKNRfQ_-1496901381")]
    [DisplayName("Technical Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechIssrCSD")]
    #endif
    [IsoXmlTag("TechIssrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator TechnicalIssuerCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TechnicalIssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TechnicalIssuerCSD { get; init; } 
    #else
    public System.String TechnicalIssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// CSD of a security.
    /// </summary>
    [IsoId("_hXacQGliEeGaMcKyqKNRfQ_1152798480")]
    [DisplayName("CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSD")]
    #endif
    [IsoXmlTag("CSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator CSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CSD { get; init; } 
    #else
    public System.String CSD { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of a security.
    /// </summary>
    [IsoId("_hXacQWliEeGaMcKyqKNRfQ_-419471499")]
    [DisplayName("Securities Quantity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyTp")]
    #endif
    [IsoXmlTag("SctiesQtyTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator SecuritiesQuantityType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecuritiesQuantityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecuritiesQuantityType { get; init; } 
    #else
    public System.String SecuritiesQuantityType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum quantity (unit or nominal) of a security.
    /// </summary>
    [IsoId("_hXacQmliEeGaMcKyqKNRfQ_912420582")]
    [DisplayName("Minimum Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDnmtn")]
    #endif
    [IsoXmlTag("MinDnmtn")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator MinimumDenomination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MinimumDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MinimumDenomination { get; init; } 
    #else
    public System.String MinimumDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity (unit or nominal) of securities.
    /// </summary>
    [IsoId("_hXacQ2liEeGaMcKyqKNRfQ_-2107680798")]
    [DisplayName("Minimum Multiple Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinMltplQty")]
    #endif
    [IsoXmlTag("MinMltplQty")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator MinimumMultipleQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MinimumMultipleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MinimumMultipleQuantity { get; init; } 
    #else
    public System.String MinimumMultipleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_hXacRGliEeGaMcKyqKNRfQ_830858922")]
    [DisplayName("Deviating Settlement Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DevtgSttlmUnit")]
    #endif
    [IsoXmlTag("DevtgSttlmUnit")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator DeviatingSettlementUnit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DeviatingSettlementUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DeviatingSettlementUnit { get; init; } 
    #else
    public System.String DeviatingSettlementUnit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
