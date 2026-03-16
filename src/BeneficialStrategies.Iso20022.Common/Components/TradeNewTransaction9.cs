// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates whether transaction is reported for the first time.
/// </summary>
[IsoId("_kmvVIf_9Eemefbt-QjTNnA")]
[DisplayName("Trade New Transaction")]
public record TradeNewTransaction9
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_ksn6sf_9Eemefbt-QjTNnA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_ksn6s__9Eemefbt-QjTNnA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData76 CounterpartyData { get; init; }

    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_ksn6tf_9Eemefbt-QjTNnA")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public required TransactionLoanData17Choice_ LoanData { get; init; }

    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [IsoId("_ksn6t__9Eemefbt-QjTNnA")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public TransactionCollateralData14Choice_? CollateralData { get; init; }

    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("_ksn6uf_9Eemefbt-QjTNnA")]
    [DisplayName("Level Type")]
    [IsoXmlTag("LvlTp")]
    public required ModificationLevel1Code LevelType { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ksn6u__9Eemefbt-QjTNnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
