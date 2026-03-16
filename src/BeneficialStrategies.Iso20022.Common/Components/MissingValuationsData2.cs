// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the outstanding derivatives for which no valuation or outdated valuation has been reported.
/// </summary>
[IsoId("_x2ECMVyGEe24CqbZJK5XxA")]
[DisplayName("Missing Valuations Data")]
public record MissingValuationsData2
{
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x24hkVyGEe24CqbZJK5XxA")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData92 CounterpartyIdentification { get; init; }

    /// <summary>
    /// Number of outstanding derivatives.
    /// </summary>
    [IsoId("_x24hk1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives")]
    [IsoXmlTag("NbOfOutsdngDerivs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; }

    /// <summary>
    /// Number of outstanding derivatives for which valuation amount was never reported.
    /// </summary>
    [IsoId("_x24hlVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With No Valuation")]
    [IsoXmlTag("NbOfOutsdngDerivsWthNoValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; }

    /// <summary>
    /// Number of outstanding derivatives with outdated valuation.
    /// </summary>
    [IsoId("_x24hl1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Valuation")]
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; }

    /// <summary>
    /// Details of missing valuations per transaction.
    /// </summary>
    [IsoId("_x24hmVyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<MissingValuationsTransactionData2> TransactionDetails { get; init; } = [];
}
