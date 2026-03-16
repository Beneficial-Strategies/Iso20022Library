// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the trading name.
/// </summary>
[IsoId("_ogVZgA4jEeK3IMoVvcTkkg")]
[DisplayName("Trading Name Modification")]
public record TradingNameModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_1Ha10A4jEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_4tgywA4jEeK3IMoVvcTkkg")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text TradingName { get; init; }
}
