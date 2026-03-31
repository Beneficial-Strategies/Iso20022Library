// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement of the journal entries for all activities related to the registered currency control contract.
/// </summary>
[IsoId("_W1hHAbGJEeuSTr8k0UEM8A")]
[DisplayName("Contract Registration Statement")]
public record ContractRegistrationStatement3
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    [IsoId("_W2ewUbGJEeuSTr8k0UEM8A")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_W2ewU7GJEeuSTr8k0UEM8A")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_W2ewVbGJEeuSTr8k0UEM8A")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Specifies the period for which the statement is provided.
    /// </summary>
    [IsoId("_W2ewV7GJEeuSTr8k0UEM8A")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod4 ReportingPeriod { get; init; }

    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    [IsoId("_W2ewWbGJEeuSTr8k0UEM8A")]
    [DisplayName("Registered Contract")]
    [IsoXmlTag("RegdCtrct")]
    public required RegisteredContract12 RegisteredContract { get; init; }

    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewW7GJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction Journal")]
    [IsoXmlTag("TxJrnl")]
    public ValueList<TransactionCertificate4> TransactionJournal { get; init; } = [];

    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewXbGJEeuSTr8k0UEM8A")]
    [DisplayName("Supporting Document Journal")]
    [IsoXmlTag("SpprtgDocJrnl")]
    public ValueList<SupportingDocument3> SupportingDocumentJournal { get; init; } = [];

    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_W2ewX7GJEeuSTr8k0UEM8A")]
    [DisplayName("Additional Supporting Document Journal")]
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    public ValueList<SupportingDocument3> AdditionalSupportingDocumentJournal { get; init; } = [];

    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    [IsoId("_W2ewYbGJEeuSTr8k0UEM8A")]
    [DisplayName("Regulatory Rule Validation")]
    [IsoXmlTag("RgltryRuleVldtn")]
    public ValueList<GenericValidationRuleIdentification1> RegulatoryRuleValidation { get; init; } =
        [];

    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    [IsoId("_W2ewY7GJEeuSTr8k0UEM8A")]
    [DisplayName("Total Contract Turnover Sum")]
    [IsoXmlTag("TtlCtrctTrnvrSum")]
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_W2ewZbGJEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
