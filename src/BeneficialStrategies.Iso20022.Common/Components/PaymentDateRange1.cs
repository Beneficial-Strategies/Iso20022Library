// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies expected and due payment date.
/// </summary>
[IsoId("_K0tXcdOAEeSQ_-lmj1tzfw")]
[DisplayName("Payment Date Range")]
public record PaymentDateRange1
{
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    [IsoId("_uqWlEdOAEeSQ_-lmj1tzfw")]
    [DisplayName("Payment Schedule Identification")]
    [IsoXmlTag("PmtSchdlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentScheduleIdentification { get; init; }

    /// <summary>
    /// Expected payment date.
    /// </summary>
    [IsoId("_LABPkdOAEeSQ_-lmj1tzfw")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; }

    /// <summary>
    /// Latest date whereby the amount must be paid.
    /// </summary>
    [IsoId("_LABPk9OAEeSQ_-lmj1tzfw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }
}
