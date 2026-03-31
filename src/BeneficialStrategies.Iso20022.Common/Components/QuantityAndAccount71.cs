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
[IsoId("_hbK9l83zEee5nJBZsW8MFQ")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount71
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_hbK9n83zEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity15Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_hbK9p83zEee5nJBZsW8MFQ")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_hbK9r83zEee5nJBZsW8MFQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_hbK9t83zEee5nJBZsW8MFQ")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown48> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_hbK9v83zEee5nJBZsW8MFQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace2? SafekeepingPlace { get; init; }
}
