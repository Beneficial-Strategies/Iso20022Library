// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regulatory transaction reporting information from the counterparty side party.
/// </summary>
[IsoId("_Bzi_4QN1Ee2-vqzwMUAewg")]
[DisplayName("Counterparty Side Transaction Reporting")]
public record CounterpartySideTransactionReporting2
{
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_B5DK4QN1Ee2-vqzwMUAewg")]
    [DisplayName("Reporting Jurisdiction")]
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportingJurisdiction { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_B5DK4wN1Ee2-vqzwMUAewg")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public PartyIdentification242Choice_? ReportingParty { get; init; }

    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Counterparty Side party.
    /// </summary>
    [IsoId("_B5DK5QN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    public ValueList<UniqueTransactionIdentifier2> CounterpartySideUniqueTransactionIdentifier { get; init; } =
        [];
}
