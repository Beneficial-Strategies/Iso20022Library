// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
[IsoId("_0mDKIQAAEeqefbt-QjTNnA")]
[DisplayName("Trade Transaction Correction")]
public record TradeTransactionCorrection9
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_0sDrgQAAEeqefbt-QjTNnA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_0sDrgwAAEeqefbt-QjTNnA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData76 CounterpartyData { get; init; }

    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_0sDrhQAAEeqefbt-QjTNnA")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public TransactionLoanData20Choice_? LoanData { get; init; }

    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [IsoId("_0sDrhwAAEeqefbt-QjTNnA")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public TransactionCollateralData14Choice_? CollateralData { get; init; }

    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("_0sDriQAAEeqefbt-QjTNnA")]
    [DisplayName("Level Type")]
    [IsoXmlTag("LvlTp")]
    public required ModificationLevel1Code LevelType { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_0sDriwAAEeqefbt-QjTNnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
