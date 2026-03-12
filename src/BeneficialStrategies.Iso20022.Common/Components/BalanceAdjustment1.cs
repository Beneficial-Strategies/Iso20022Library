// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the balance adjustments for a specific service.
/// </summary>
[IsoId("_6SVpUpqlEeGSON8vddiWzQ_304866201")]
[DisplayName("Balance Adjustment")]
public partial record BalanceAdjustment1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of adjustment.
    /// </summary>
    [IsoId("_6SVpU5qlEeGSON8vddiWzQ_-313393721")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceAdjustmentType1Code Type { get; init; } 
    
    /// <summary>
    /// Free-form description and clarification of the adjustment.
    /// </summary>
    [IsoId("_6SVpVJqlEeGSON8vddiWzQ_1088798456")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text Description { get; init; } 
    
    /// <summary>
    /// Amount of the adjustment. If the amount would reduce the underlying balance then the amount should be negatively signed. Expressed in the Account currency.
    /// </summary>
    [IsoId("_6SVpVZqlEeGSON8vddiWzQ_939741632")]
    [DisplayName("Balance Amount")]
    [IsoXmlTag("BalAmt")]
    public required AmountAndDirection34 BalanceAmount { get; init; } 
    
    /// <summary>
    /// Day-weighted net amount of the adjustment to the average collected balance over the statement period.
    /// </summary>
    [IsoId("_6SVpVpqlEeGSON8vddiWzQ_1558874866")]
    [DisplayName("Average Amount")]
    [IsoXmlTag("AvrgAmt")]
    public AmountAndDirection34? AverageAmount { get; init; } 
    
    /// <summary>
    /// Date on which the error occurred in the underlying cash account.
    /// </summary>
    [IsoId("_6SVpV5qlEeGSON8vddiWzQ_561802513")]
    [DisplayName("Error Date")]
    [IsoXmlTag("ErrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ErrorDate { get; init; } 
    
    /// <summary>
    /// Date on which the error was corrected in the cash account. If the date is not know then use the last day of the month in which the error was corrected.
    /// </summary>
    [IsoId("_6SezQJqlEeGSON8vddiWzQ_-435269840")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PostingDate { get; init; } 
    
    /// <summary>
    /// Number of days within the period to which the adjustment applies.
    /// </summary>
    [IsoId("_6SezQZqlEeGSON8vddiWzQ_1103518602")]
    [DisplayName("Days")]
    [IsoXmlTag("Days")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Days { get; init; } 
    
    /// <summary>
    /// Earnings credit adjustment, debit or credit, resulting from this adjustment’s effect on the average collected balance. If the amount would reduce the credit due then the amount should be negatively signed.
    /// </summary>
    [IsoId("_6SezQpqlEeGSON8vddiWzQ_398403987")]
    [DisplayName("Earnings Adjustment Amount")]
    [IsoXmlTag("EarngsAdjstmntAmt")]
    public AmountAndDirection34? EarningsAdjustmentAmount { get; init; } 
    
    
    #nullable disable
    
}
