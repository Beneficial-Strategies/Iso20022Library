// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an payment schedule, that is an amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
[IsoId("_L71BftOJEeSQ_-lmj1tzfw")]
[DisplayName("Payment Date Range")]
public partial record PaymentDateRange2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    [IsoId("_L71Bg9OJEeSQ_-lmj1tzfw")]
    [DisplayName("Payment Schedule Identification")]
    [IsoXmlTag("PmtSchdlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
    
    /// <summary>
    /// Amount that must be paid no sooner than the expected payment date and no later than the due date.
    /// </summary>
    [IsoId("_L71BgdOJEeSQ_-lmj1tzfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Expected date whereby the amount must be paid.
    /// </summary>
    [IsoId("_L71BgNOJEeSQ_-lmj1tzfw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; } 
    
    /// <summary>
    /// Latest date whereby the amount of money must be paid.
    /// </summary>
    [IsoId("_L71Bf9OJEeSQ_-lmj1tzfw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DueDate { get; init; } 
    
    
    #nullable disable
    
}
