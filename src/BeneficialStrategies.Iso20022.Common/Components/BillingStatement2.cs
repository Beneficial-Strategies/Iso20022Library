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
/// Details of the statement reporting the bank services billing.
/// </summary>
[IsoId("_arIxfTq2EeWZFYSPlduMhw")]
[DisplayName("Billing Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingStatement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingStatement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingStatement2( System.String reqStatementIdentification,DatePeriod1 reqFromToDate,System.DateTime reqCreationDateTime,BillingStatementStatus1Code reqStatus,CashAccountCharacteristics2 reqAccountCharacteristics )
    {
        StatementIdentification = reqStatementIdentification;
        FromToDate = reqFromToDate;
        CreationDateTime = reqCreationDateTime;
        Status = reqStatus;
        AccountCharacteristics = reqAccountCharacteristics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    [IsoId("_ayMbsTq2EeWZFYSPlduMhw")]
    [DisplayName("Statement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtId")]
    #endif
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text StatementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatementIdentification { get; init; } 
    #else
    public System.String StatementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    [IsoId("_ayMbszq2EeWZFYSPlduMhw")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DatePeriod1 FromToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DatePeriod1 FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod1 FromToDate { get; init; } 
    #else
    public DatePeriod1 FromToDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    [IsoId("_ayMbtTq2EeWZFYSPlduMhw")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    [IsoId("_ayMbtzq2EeWZFYSPlduMhw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingStatementStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingStatementStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingStatementStatus1Code Status { get; init; } 
    #else
    public BillingStatementStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    [IsoId("_ayMbuTq2EeWZFYSPlduMhw")]
    [DisplayName("Account Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctChrtcs")]
    #endif
    [IsoXmlTag("AcctChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccountCharacteristics2 AccountCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccountCharacteristics2 AccountCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountCharacteristics2 AccountCharacteristics { get; init; } 
    #else
    public CashAccountCharacteristics2 AccountCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    [IsoId("_ayMbuzq2EeWZFYSPlduMhw")]
    [DisplayName("Rate Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateData")]
    #endif
    [IsoXmlTag("RateData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingRate1? RateData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingRate1? RateData { get; init; } 
    #else
    public BillingRate1? RateData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    [IsoId("_ayMbvTq2EeWZFYSPlduMhw")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchg")]
    #endif
    [IsoXmlTag("CcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange6? CurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange6? CurrencyExchange { get; init; } 
    #else
    public CurrencyExchange6? CurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    [IsoId("_ayMbvzq2EeWZFYSPlduMhw")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingBalance1? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingBalance1? Balance { get; init; } 
    #else
    public BillingBalance1? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    [IsoId("_ayMbwTq2EeWZFYSPlduMhw")]
    [DisplayName("Compensation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Compstn")]
    #endif
    [IsoXmlTag("Compstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingCompensation1? Compensation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingCompensation1? Compensation { get; init; } 
    #else
    public BillingCompensation1? Compensation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    [IsoId("_ayMbwzq2EeWZFYSPlduMhw")]
    [DisplayName("Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svc")]
    #endif
    [IsoXmlTag("Svc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingService2? Service { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingService2? Service { get; init; } 
    #else
    public BillingService2? Service { get; set; } 
    #endif
    
    /// <summary>
    /// Tax region(s) that levy a tax on the services within this statement.
    /// </summary>
    [IsoId("_ayMbxTq2EeWZFYSPlduMhw")]
    [DisplayName("Tax Region")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRgn")]
    #endif
    [IsoXmlTag("TaxRgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingTaxRegion1? TaxRegion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingTaxRegion1? TaxRegion { get; init; } 
    #else
    public BillingTaxRegion1? TaxRegion { get; set; } 
    #endif
    
    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_ayMbxzq2EeWZFYSPlduMhw")]
    [DisplayName("Balance Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAdjstmnt")]
    #endif
    [IsoXmlTag("BalAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceAdjustment1? BalanceAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAdjustment1? BalanceAdjustment { get; init; } 
    #else
    public BalanceAdjustment1? BalanceAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_ayMbyTq2EeWZFYSPlduMhw")]
    [DisplayName("Service Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcAdjstmnt")]
    #endif
    [IsoXmlTag("SvcAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; } 
    #else
    public BillingServiceAdjustment1? ServiceAdjustment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
