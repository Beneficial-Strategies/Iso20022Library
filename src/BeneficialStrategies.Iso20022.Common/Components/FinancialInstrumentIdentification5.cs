// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Instrument Identification5.
/// </summary>
[IsoId("_e0TXVX_8Ee-5A_neRtHpSQ")]
[DisplayName("Financial Instrument Identification5")]
public record FinancialInstrumentIdentification5
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }
}
