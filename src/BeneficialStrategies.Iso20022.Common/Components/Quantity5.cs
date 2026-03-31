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
[IsoId("_UdF0btp-Ed-ak6NoX_4Aeg_1583075318")]
[DisplayName("Quantity")]
public record Quantity5
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_UdF0b9p-Ed-ak6NoX_4Aeg_1583076297")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_UdF0cNp-Ed-ak6NoX_4Aeg_1583075433")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_UdF0cdp-Ed-ak6NoX_4Aeg_635399869")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public ValueList<SecuritiesCertificate1> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_UdF0ctp-Ed-ak6NoX_4Aeg_-851463689")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown3> QuantityBreakdown { get; init; } = [];
}
