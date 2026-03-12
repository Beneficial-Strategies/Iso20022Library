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
[IsoId("_QeqY8bJVEeuX8-p7DPhoRw")]
[DisplayName("Payment Schedule")]
public partial record PaymentSchedule1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    [IsoId("_QgascbJVEeuX8-p7DPhoRw")]
    [DisplayName("Payment Schedule Identification")]
    [IsoXmlTag("PmtSchdlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
    
    /// <summary>
    /// Amount that must be paid no sooner than the expected payment date and no later than the due date.
    /// </summary>
    [IsoId("_Qgasc7JVEeuX8-p7DPhoRw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Expected date whereby the amount must be paid.
    /// </summary>
    [IsoId("_QgasdbJVEeuX8-p7DPhoRw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; } 
    
    /// <summary>
    /// Latest date whereby the amount of money must be paid.
    /// </summary>
    [IsoId("_Qgasd7JVEeuX8-p7DPhoRw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; } 
    
    /// <summary>
    /// Further details on the payments.
    /// </summary>
    [IsoId("_R9n00LJWEeuX8-p7DPhoRw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
