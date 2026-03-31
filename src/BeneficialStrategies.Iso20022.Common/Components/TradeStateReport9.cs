// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details for a trade state report.
/// </summary>
[IsoId("_fCvndQAFEeqefbt-QjTNnA")]
[DisplayName("Trade State Report")]
public record TradeStateReport9
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_fH7CYQAFEeqefbt-QjTNnA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_fH7CYwAFEeqefbt-QjTNnA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData76 CounterpartyData { get; init; }

    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_fH7CZQAFEeqefbt-QjTNnA")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public TransactionLoanData20Choice_? LoanData { get; init; }

    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [IsoId("_fH7CZwAFEeqefbt-QjTNnA")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public TransactionCollateralData15Choice_? CollateralData { get; init; }

    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_fH7CaQAFEeqefbt-QjTNnA")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public ReconciliationFlag1? ReconciliationFlag { get; init; }

    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_fH7CawAFEeqefbt-QjTNnA")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public required ContractModification2 ContractModification { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_fH7CbQAFEeqefbt-QjTNnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
