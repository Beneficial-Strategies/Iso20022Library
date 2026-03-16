// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Registration Statement4.
/// </summary>
[IsoId("_4g7KUTEyEe6g-ffJsqGiSA")]
[DisplayName("Contract Registration Statement4")]
public partial record ContractRegistrationStatement4
{
    #nullable enable

    /// <summary>
    /// Additional Supporting Document Journal.
    /// </summary>
    [DisplayName("Additional Supporting Document Journal")]
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    public ValueList<SupportingDocument4> AdditionalSupportingDocumentJournal { get; init; } = [];

    /// <summary>
    /// Registered Contract.
    /// </summary>
    [DisplayName("Registered Contract")]
    [IsoXmlTag("RegdCtrct")]
    public required RegisteredContract18 RegisteredContract { get; init; } 

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; } 

    /// <summary>
    /// Regulatory Rule Validation.
    /// </summary>
    [DisplayName("Regulatory Rule Validation")]
    [IsoXmlTag("RgltryRuleVldtn")]
    public ValueList<GenericValidationRuleIdentification1> RegulatoryRuleValidation { get; init; } = [];

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty6 ReportingParty { get; init; } 

    /// <summary>
    /// Reporting Period.
    /// </summary>
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod4 ReportingPeriod { get; init; } 

    /// <summary>
    /// Statement Identification.
    /// </summary>
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    public IsoMax35Text? StatementIdentification { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Supporting Document Journal.
    /// </summary>
    [DisplayName("Supporting Document Journal")]
    [IsoXmlTag("SpprtgDocJrnl")]
    public ValueList<SupportingDocument4> SupportingDocumentJournal { get; init; } = [];

    /// <summary>
    /// Total Contract Turnover Sum.
    /// </summary>
    [DisplayName("Total Contract Turnover Sum")]
    [IsoXmlTag("TtlCtrctTrnvrSum")]
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 

    /// <summary>
    /// Transaction Journal.
    /// </summary>
    [DisplayName("Transaction Journal")]
    [IsoXmlTag("TxJrnl")]
    public ValueList<TransactionCertificate4> TransactionJournal { get; init; } = [];

    
    #nullable disable
    
}
