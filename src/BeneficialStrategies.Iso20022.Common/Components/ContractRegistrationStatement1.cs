// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement of the journal entries for all activities related to the registered currency control contract.
/// </summary>
[IsoId("_M2smkNnREeS--7IJLPC9lw")]
[DisplayName("Contract Registration Statement")]
public partial record ContractRegistrationStatement1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    [IsoId("_UdiaUdoMEeS--7IJLPC9lw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; } 
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_7FIUguFGEeStTblywAGIyA")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty2 ReportingParty { get; init; } 
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_7FIUg-FGEeStTblywAGIyA")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Specifies the period for which the statement is provided.
    /// </summary>
    [IsoId("_M51uAN9fEeSC7c30wG4jEQ")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod1 ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    [IsoId("_SHQhQNnREeS--7IJLPC9lw")]
    [DisplayName("Registered Contract")]
    [IsoXmlTag("RegdCtrct")]
    public required RegisteredContract5 RegisteredContract { get; init; } 
    
    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_VScq4NnREeS--7IJLPC9lw")]
    [DisplayName("Transaction Journal")]
    [IsoXmlTag("TxJrnl")]
    public TransactionCertificate1? TransactionJournal { get; init; } 
    
    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_WxgC0NnREeS--7IJLPC9lw")]
    [DisplayName("Supporting Document Journal")]
    [IsoXmlTag("SpprtgDocJrnl")]
    public SupportingDocument1? SupportingDocumentJournal { get; init; } 
    
    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    [IsoId("_cJCvQNnREeS--7IJLPC9lw")]
    [DisplayName("Additional Supporting Document Journal")]
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    public SupportingDocument1? AdditionalSupportingDocumentJournal { get; init; } 
    
    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    [IsoId("_eqWOYNnREeS--7IJLPC9lw")]
    [DisplayName("Regulatory Rule Validation")]
    [IsoXmlTag("RgltryRuleVldtn")]
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; init; } 
    
    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    [IsoId("_mpufwNnREeS--7IJLPC9lw")]
    [DisplayName("Total Contract Turnover Sum")]
    [IsoXmlTag("TtlCtrctTrnvrSum")]
    public required ActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qPwb8QtNEeWkxvNyFrBT8Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
