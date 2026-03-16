// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details of the electronic invoice.
/// </summary>
[IsoId("_7qk3ikWdEempSe_3C1a9EQ")]
[DisplayName("Electronic Invoice")]
public record ElectronicInvoice1
{
    /// <summary>
    /// Type of elements to be presented in the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_4OShYUWeEempSe_3C1a9EQ")]
    [DisplayName("Presentment Type")]
    [IsoXmlTag("PresntmntTp")]
    public required PresentmentType1Code PresentmentType { get; init; }
}
