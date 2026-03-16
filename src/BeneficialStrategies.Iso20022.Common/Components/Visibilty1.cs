// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the visibility of the creditor enrolment as shown to the debtors.
/// </summary>
[IsoId("_FnUAsEWOEempSe_3C1a9EQ")]
[DisplayName("Visibilty")]
public record Visibilty1
{
    /// <summary>
    /// Start date when the information will be shown to the debtors.
    /// </summary>
    [IsoId("_NQ95sEWOEempSe_3C1a9EQ")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public DateAndDateTime2Choice_? StartDate { get; init; }

    /// <summary>
    /// End date when the information will be shown to the debtors.
    /// </summary>
    [IsoId("_RliGMEWOEempSe_3C1a9EQ")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public DateAndDateTime2Choice_? EndDate { get; init; }

    /// <summary>
    /// Indicates whether the information is shown to the debtors or not.
    /// Usage: when absent, the default value is no limited visibility (false).
    /// </summary>
    [IsoId("_cjMGkEWOEempSe_3C1a9EQ")]
    [DisplayName("Limited Visibility")]
    [IsoXmlTag("LtdVsblty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LimitedVisibility { get; init; }
}
