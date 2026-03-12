// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.010.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.
/// 
/// Usage:
/// The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.
/// 
/// </summary>
[Description(@"Scope:|The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.||Usage:|The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.|")]
[IsoId("_LwDQLcP_Eemsic1bQcEtLA")]
[DisplayName("Financial Institution Direct Debit V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionDirectDebitV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.010.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIDrctDbt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstitutionDirectDebitV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstitutionDirectDebitV04( GroupHeader92 reqGroupHeader,CreditTransferTransaction47 reqCreditInstruction )
    {
        GroupHeader = reqGroupHeader;
        CreditInstruction = reqCreditInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common characteristics for all individual transactions included in the message.
    /// </summary>
    [IsoId("_LwDQNcP_Eemsic1bQcEtLA")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader92 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader92 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader92 GroupHeader { get; init; } 
    #else
    public GroupHeader92 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics that apply to the credit side of the payment transaction(s) included in the message.
    /// </summary>
    [IsoId("_LwDQN8P_Eemsic1bQcEtLA")]
    [DisplayName("Credit Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInstr")]
    #endif
    [IsoXmlTag("CdtInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditTransferTransaction47 CreditInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditTransferTransaction47 CreditInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransaction47 CreditInstruction { get; init; } 
    #else
    public CreditTransferTransaction47 CreditInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LwDQOcP_Eemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since FinancialInstitutionDirectDebitV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstitutionDirectDebitV04.

