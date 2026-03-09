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
/// Specifies the balance adjustments for a specific service.
/// </summary>
[IsoId("_6SVpUpqlEeGSON8vddiWzQ_304866201")]
[DisplayName("Balance Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceAdjustment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BalanceAdjustment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BalanceAdjustment1( BalanceAdjustmentType1Code reqType,System.String reqDescription,AmountAndDirection34 reqBalanceAmount,System.DateOnly reqPostingDate )
    {
        Type = reqType;
        Description = reqDescription;
        BalanceAmount = reqBalanceAmount;
        PostingDate = reqPostingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of adjustment.
    /// </summary>
    [IsoId("_6SVpU5qlEeGSON8vddiWzQ_-313393721")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceAdjustmentType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceAdjustmentType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceAdjustmentType1Code Type { get; init; } 
    #else
    public BalanceAdjustmentType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Free-form description and clarification of the adjustment.
    /// </summary>
    [IsoId("_6SVpVJqlEeGSON8vddiWzQ_1088798456")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the adjustment. If the amount would reduce the underlying balance then the amount should be negatively signed. Expressed in the Account currency.
    /// </summary>
    [IsoId("_6SVpVZqlEeGSON8vddiWzQ_939741632")]
    [DisplayName("Balance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAmt")]
    #endif
    [IsoXmlTag("BalAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 BalanceAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 BalanceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 BalanceAmount { get; init; } 
    #else
    public AmountAndDirection34 BalanceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Day-weighted net amount of the adjustment to the average collected balance over the statement period.
    /// </summary>
    [IsoId("_6SVpVpqlEeGSON8vddiWzQ_1558874866")]
    [DisplayName("Average Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgAmt")]
    #endif
    [IsoXmlTag("AvrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? AverageAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? AverageAmount { get; init; } 
    #else
    public AmountAndDirection34? AverageAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the error occurred in the underlying cash account.
    /// </summary>
    [IsoId("_6SVpV5qlEeGSON8vddiWzQ_561802513")]
    [DisplayName("Error Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrDt")]
    #endif
    [IsoXmlTag("ErrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ErrorDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ErrorDate { get; init; } 
    #else
    public System.DateOnly? ErrorDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the error was corrected in the cash account. If the date is not know then use the last day of the month in which the error was corrected.
    /// </summary>
    [IsoId("_6SezQJqlEeGSON8vddiWzQ_-435269840")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PostingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PostingDate { get; init; } 
    #else
    public System.DateOnly PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days within the period to which the adjustment applies.
    /// </summary>
    [IsoId("_6SezQZqlEeGSON8vddiWzQ_1103518602")]
    [DisplayName("Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Days")]
    #endif
    [IsoXmlTag("Days")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Days { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Days { get; init; } 
    #else
    public System.UInt64? Days { get; set; } 
    #endif
    
    /// <summary>
    /// Earnings credit adjustment, debit or credit, resulting from this adjustment’s effect on the average collected balance. If the amount would reduce the credit due then the amount should be negatively signed.
    /// </summary>
    [IsoId("_6SezQpqlEeGSON8vddiWzQ_398403987")]
    [DisplayName("Earnings Adjustment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarngsAdjstmntAmt")]
    #endif
    [IsoXmlTag("EarngsAdjstmntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? EarningsAdjustmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? EarningsAdjustmentAmount { get; init; } 
    #else
    public AmountAndDirection34? EarningsAdjustmentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
