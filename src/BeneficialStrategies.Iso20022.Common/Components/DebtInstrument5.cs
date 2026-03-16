// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the debit instrument.
/// </summary>
[IsoId("_PCM3wX5gEea2k7EBUopqxw")]
[DisplayName("Debt Instrument")]
public record DebtInstrument5
{
    /// <summary>
    /// Specifies the type of bond type.
    /// </summary>
    [IsoId("_PO2MoX5gEea2k7EBUopqxw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BondType1Code Type { get; init; }

    /// <summary>
    /// Date on which a bond is issued and begins to accrue interest.
    /// </summary>
    [IsoId("_PO2Mo35gEea2k7EBUopqxw")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssuanceDate { get; init; }
}
