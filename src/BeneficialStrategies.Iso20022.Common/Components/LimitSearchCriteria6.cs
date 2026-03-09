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
/// Defines the criteria used to search for a limit.
/// </summary>
[IsoId("_FZ5lXW4-EeiU9cctagi5ow")]
[DisplayName("Limit Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitSearchCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_Fkedp24-EeiU9cctagi5ow")]
    [DisplayName("System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysId")]
    #endif
    [IsoXmlTag("SysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    #else
    public SystemIdentification2Choice_? SystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_FkedqW4-EeiU9cctagi5ow")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtCtrPtyId")]
    #endif
    [IsoXmlTag("BilLmtCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_Fkedq24-EeiU9cctagi5ow")]
    [DisplayName("Default Limit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltLmtTp")]
    #endif
    [IsoXmlTag("DfltLmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitType1Choice_? DefaultLimitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitType1Choice_? DefaultLimitType { get; init; } 
    #else
    public LimitType1Choice_? DefaultLimitType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    [IsoId("_FkedrW4-EeiU9cctagi5ow")]
    [DisplayName("Current Limit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurLmtTp")]
    #endif
    [IsoXmlTag("CurLmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitType1Choice_? CurrentLimitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitType1Choice_? CurrentLimitType { get; init; } 
    #else
    public LimitType1Choice_? CurrentLimitType { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_Fkedr24-EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_FkedsW4-EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Actual usage of the limit expressed as an amount.
    /// </summary>
    [IsoId("_Fkeds24-EeiU9cctagi5ow")]
    [DisplayName("Used Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsdAmt")]
    #endif
    [IsoXmlTag("UsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveAmountRange3Choice_? UsedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveAmountRange3Choice_? UsedAmount { get; init; } 
    #else
    public ActiveAmountRange3Choice_? UsedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Actual usage of the limit expressed as a percentage.
    /// </summary>
    [IsoId("_FkedtW4-EeiU9cctagi5ow")]
    [DisplayName("Used Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsdPctg")]
    #endif
    [IsoXmlTag("UsdPctg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PercentageRange1Choice_? UsedPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageRange1Choice_? UsedPercentage { get; init; } 
    #else
    public PercentageRange1Choice_? UsedPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_Fkedt24-EeiU9cctagi5ow")]
    [DisplayName("Limit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtCcy")]
    #endif
    [IsoXmlTag("LmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LimitCurrency { get; init; } 
    #else
    public string? LimitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_FkeduW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtAmt")]
    #endif
    [IsoXmlTag("LmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveAmountRange3Choice_? LimitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveAmountRange3Choice_? LimitAmount { get; init; } 
    #else
    public ActiveAmountRange3Choice_? LimitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Range of dates when the limit becomes valid.
    /// </summary>
    [IsoId("_Fkedu24-EeiU9cctagi5ow")]
    [DisplayName("Limit Valid As Of Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtVldAsOfDt")]
    #endif
    [IsoXmlTag("LmtVldAsOfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; } 
    #else
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
