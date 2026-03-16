// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity in charge of the settlement reporting service.
/// </summary>
[IsoId("_kLz1YEX7Eeegp_DADCe7HQ")]
[DisplayName("Settlement Reporting Entity")]
public record SettlementReportingEntity1
{
    /// <summary>
    /// Identifies the type of settlement reporting entity
    /// </summary>
    [IsoId("_8QsxwEX7Eeegp_DADCe7HQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Identification of the settlement reporting entity.
    /// </summary>
    [IsoId("_BKJM8EX8Eeegp_DADCe7HQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }
}
