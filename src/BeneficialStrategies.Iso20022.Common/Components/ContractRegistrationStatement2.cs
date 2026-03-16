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
[IsoId("_TYk8IW49EeiU9cctagi5ow")]
[DisplayName("Contract Registration Statement")]
public record ContractRegistrationStatement2
{
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    [IsoId("_TitIgW49EeiU9cctagi5ow")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_TitIg249EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_TitIhW49EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// Specifies the period for which the statement is provided.
    /// </summary>
    [IsoId("_TitIh249EeiU9cctagi5ow")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod4 ReportingPeriod { get; init; }

    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    [IsoId("_TitIiW49EeiU9cctagi5ow")]
    [DisplayName("Registered Contract")]
    [IsoXmlTag("RegdCtrct")]
    public required RegisteredContract8 RegisteredContract { get; init; }

    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_TitIi249EeiU9cctagi5ow")]
    [DisplayName("Transaction Journal")]
    [IsoXmlTag("TxJrnl")]
    public TransactionCertificate3? TransactionJournal { get; init; }

    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_TitIjW49EeiU9cctagi5ow")]
    [DisplayName("Supporting Document Journal")]
    [IsoXmlTag("SpprtgDocJrnl")]
    public SupportingDocument2? SupportingDocumentJournal { get; init; }

    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_TitIj249EeiU9cctagi5ow")]
    [DisplayName("Additional Supporting Document Journal")]
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    public SupportingDocument2? AdditionalSupportingDocumentJournal { get; init; }

    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    [IsoId("_TitIkW49EeiU9cctagi5ow")]
    [DisplayName("Regulatory Rule Validation")]
    [IsoXmlTag("RgltryRuleVldtn")]
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; init; }

    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    [IsoId("_TitIk249EeiU9cctagi5ow")]
    [DisplayName("Total Contract Turnover Sum")]
    [IsoXmlTag("TtlCtrctTrnvrSum")]
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_TitIlW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
