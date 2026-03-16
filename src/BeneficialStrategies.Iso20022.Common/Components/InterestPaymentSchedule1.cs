// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an interest payment schedule, that is an amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
[IsoId("_Vexc0bJVEeuX8-p7DPhoRw")]
[DisplayName("Interest Payment Schedule")]
public record InterestPaymentSchedule1
{
    /// <summary>
    /// Unique and unambiguous identification of the interest payment schedule.
    /// </summary>
    [IsoId("_VgFrcbJVEeuX8-p7DPhoRw")]
    [DisplayName("Interest Schedule Identification")]
    [IsoXmlTag("IntrstSchdlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterestScheduleIdentification { get; init; }

    /// <summary>
    /// Interest amount that must be paid at due date.
    /// </summary>
    [IsoId("_VgFrc7JVEeuX8-p7DPhoRw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Expected interest payment date.
    /// </summary>
    [IsoId("_5UDBkLJWEeuX8-p7DPhoRw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; }

    /// <summary>
    /// Latest date whereby the interest must be paid.
    /// </summary>
    [IsoId("_VgFrdbJVEeuX8-p7DPhoRw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Further details on the interest payments.
    /// </summary>
    [IsoId("_VgFrd7JVEeuX8-p7DPhoRw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
