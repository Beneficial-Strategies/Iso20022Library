// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the legal basis of the request.
/// </summary>
[IsoId("_bhYnwEJ4EeGuetKibuqsKw")]
[DisplayName("Legal Mandate")]
public record LegalMandate1
{
    /// <summary>
    /// Identifies the legal mandate paragraph in law which gives power to the authority&apos;s request.
    /// </summary>
    [IsoId("_ZiG61UJ8EeGuetKibuqsKw")]
    [DisplayName("Paragraph")]
    [IsoXmlTag("Prgrph")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Paragraph { get; init; }

    /// <summary>
    /// Specifies any additional information describing how or why the paragraph of law should be applied.
    /// </summary>
    [IsoId("_buerxUJ8EeGuetKibuqsKw")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Disclaimer { get; init; }
}
