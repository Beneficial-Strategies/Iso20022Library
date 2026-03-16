// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_0M-9ITkkEeahTcrfPSjpxA")]
[DisplayName("Fee And Tax")]
public record FeeAndTax1
{
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_OX0W0XTEEea79aegl3yVYg")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_0lFUGzkkEeahTcrfPSjpxA")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee1> IndividualFee { get; init; } = [];

    /// <summary>
    /// Individual tax amount.
    /// </summary>
    [IsoId("_0lFUHTkkEeahTcrfPSjpxA")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax30> IndividualTax { get; init; } = [];
}
