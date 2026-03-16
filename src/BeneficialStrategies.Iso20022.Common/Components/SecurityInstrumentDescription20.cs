// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_sAOv553CEeuwmdq0KtnICg")]
[DisplayName("Security Instrument Description")]
public record SecurityInstrumentDescription20
{
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_sY0PAZ3CEeuwmdq0KtnICg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISIN2021Identifier)]
    public IsoISIN2021Identifier? Identification { get; init; }

    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_sY0PA53CEeuwmdq0KtnICg")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullName { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO classification of financial instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_sY0PBZ3CEeuwmdq0KtnICg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public required IsoCFIOct2015Identifier ClassificationType { get; init; }

    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_sY0PCZ3CEeuwmdq0KtnICg")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; }
}
