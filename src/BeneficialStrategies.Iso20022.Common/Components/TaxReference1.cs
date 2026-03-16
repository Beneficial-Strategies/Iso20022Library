// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pension scheme tax reference.
/// </summary>
[IsoId("_jUsPcE4QEeiQHa-q1Uephw")]
[DisplayName("Tax Reference")]
public record TaxReference1
{
    /// <summary>
    /// Type of tax reference.
    /// </summary>
    [IsoId("_x0JioE4QEeiQHa-q1Uephw")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    public TaxReferenceType1Choice_? TaxType { get; init; }

    /// <summary>
    /// Tax reference.
    /// </summary>
    [IsoId("_1V_RsE4QEeiQHa-q1Uephw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Type of reference holder. For example, the transferee&apos;s tax reference. The transferee may also be known as the acquiring party.
    /// </summary>
    [IsoId("_refLoE4REeiQHa-q1Uephw")]
    [DisplayName("Holder Type")]
    [IsoXmlTag("HldrTp")]
    public TaxReferenceParty1Choice_? HolderType { get; init; }
}
