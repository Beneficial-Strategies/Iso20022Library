// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
[IsoId("_HvMMX7PvEeelzbgsFa3sqQ")]
[DisplayName("Quantity")]
public record Quantity14
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_H_jjkbPvEeelzbgsFa3sqQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_H_jjmbPvEeelzbgsFa3sqQ")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_H_jjobPvEeelzbgsFa3sqQ")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public ValueList<SecuritiesCertificate4> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_H_jjqbPvEeelzbgsFa3sqQ")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown46> QuantityBreakdown { get; init; } = [];
}
