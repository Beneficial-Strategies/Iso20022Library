// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information as expected by the party that the investigation performs the expected actions for its resolution.
/// </summary>
[IsoId("_pVo7ZcQHEemsic1bQcEtLA")]
[DisplayName("Resolution Data")]
public record ResolutionData2
{
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_pg0Qg8QHEemsic1bQcEtLA")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_pg0QhcQHEemsic1bQcEtLA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_pg0Qh8QHEemsic1bQcEtLA")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_pg0QicQHEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_pg0Qi8QHEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_pg0QjcQHEemsic1bQcEtLA")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <summary>
    /// Provides the details of the compensation made due to the modification or cancellation of a previous payment.
    /// </summary>
    [IsoId("_pg0Qj8QHEemsic1bQcEtLA")]
    [DisplayName("Compensation")]
    [IsoXmlTag("Compstn")]
    public Compensation3? Compensation { get; init; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_pg0QkcQHEemsic1bQcEtLA")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<Charges8> Charges { get; init; } = [];
}
