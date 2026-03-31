// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_SdZNhdp-Ed-ak6NoX_4Aeg_70923680")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument12
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_SdZNhtp-Ed-ak6NoX_4Aeg_70923800")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_SdZNh9p-Ed-ak6NoX_4Aeg_70923877")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }
}
