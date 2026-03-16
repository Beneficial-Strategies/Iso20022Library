// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specify the ISIN(s) and / or LEI(s) that are present in a basket.
/// </summary>
[IsoId("_a46r4PBqEeWTAY6i--T_aA")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument53
{
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_a46r4fBqEeWTAY6i--T_aA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public SimpleValueList<IsoISINOct2015Identifier> ISIN { get; init; } = [];

    /// <summary>
    /// The LEI code of the issuer where the instrument is referring to an issuer rather than one single instrument.
    /// </summary>
    [IsoId("_a46r4vBqEeWTAY6i--T_aA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public SimpleValueList<IsoLEIIdentifier> LEI { get; init; } = [];
}
