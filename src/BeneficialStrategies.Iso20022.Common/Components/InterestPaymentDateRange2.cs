// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an interest payment schedule, that is an amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
[IsoId("_es4FpdOJEeSQ_-lmj1tzfw")]
[DisplayName("Interest Payment Date Range")]
public partial record InterestPaymentDateRange2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the interest payment schedule.
    /// </summary>
    [IsoId("_es4FptOJEeSQ_-lmj1tzfw")]
    [DisplayName("Interest Schedule Identification")]
    [IsoXmlTag("IntrstSchdlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InterestScheduleIdentification { get; init; } 
    
    /// <summary>
    /// Interest amount that must be paid at due date.
    /// </summary>
    [IsoId("_es4FqdOJEeSQ_-lmj1tzfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Latest date whereby the interest must be paid.
    /// </summary>
    [IsoId("_es4FqNOJEeSQ_-lmj1tzfw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DueDate { get; init; } 
    
    /// <summary>
    /// Further details on the interest payments.
    /// </summary>
    [IsoId("_obya8dOJEeSQ_-lmj1tzfw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
