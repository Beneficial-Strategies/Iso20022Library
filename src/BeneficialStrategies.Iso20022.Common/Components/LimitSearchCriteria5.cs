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
[IsoId("_PwPj_ZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Limit Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitSearchCriteria5
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
    [IsoId("_P4oq95lcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4oq-ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtCtrPtyId")]
    #endif
    [IsoXmlTag("BilLmtCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    [IsoId("_P4oq-5lcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4oq_ZlcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4oq_5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_P4orAZlcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4orA5lcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4orBZlcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4orB5lcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4orCZlcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_P4orC5lcEeeE1Ya-LgRsuQ")]
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
