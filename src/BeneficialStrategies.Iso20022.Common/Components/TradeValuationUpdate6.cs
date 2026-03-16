// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates an update to the valuations of a previously reported position, but not a correction.
/// </summary>
[IsoId("_MVyUsbQ4EemI67HK7aviyg")]
[DisplayName("Trade Valuation Update")]
public record TradeValuationUpdate6
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_MaG0AbQ4EemI67HK7aviyg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_MaG0A7Q4EemI67HK7aviyg")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData76 CounterpartyData { get; init; }

    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_MaG0BbQ4EemI67HK7aviyg")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public required LoanData85 LoanData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_MaG0B7Q4EemI67HK7aviyg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
