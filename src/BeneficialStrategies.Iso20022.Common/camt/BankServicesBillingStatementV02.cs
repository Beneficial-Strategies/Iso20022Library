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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.086.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.
/// Usage
/// The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatement message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.
/// The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BankServicesBillingStatement does not ask the financial institution to revise its established pricing and billing procedures. 
/// How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the financial institution to aggregate and report what actually happened during the calendar month.
/// The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.
/// </summary>
[Description(@"Scope|The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.|Usage|The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatement message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.|The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BankServicesBillingStatement does not ask the financial institution to revise its established pricing and billing procedures. |How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the financial institution to aggregate and report what actually happened during the calendar month.|The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.")]
[IsoId("_sHrTETqxEeWZFYSPlduMhw")]
[DisplayName("Bank Services Billing Statement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankServicesBillingStatementV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.086.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkSvcsBllgStmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.086.001.02";
    
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
    /// Constructs a BankServicesBillingStatementV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankServicesBillingStatementV02( ReportHeader3 reqReportHeader,StatementGroup2 reqBillingStatementGroup )
    {
        ReportHeader = reqReportHeader;
        BillingStatementGroup = reqBillingStatementGroup;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides header details on the billing statement report.
    /// </summary>
    [IsoId("_sHrTEzqxEeWZFYSPlduMhw")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportHeader3 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportHeader3 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportHeader3 ReportHeader { get; init; } 
    #else
    public ReportHeader3 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Group of bank services billing statements with the same sender and receiver characteristics.
    /// </summary>
    [IsoId("_sHrTFTqxEeWZFYSPlduMhw")]
    [DisplayName("Billing Statement Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgStmtGrp")]
    #endif
    [IsoXmlTag("BllgStmtGrp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementGroup2 BillingStatementGroup { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementGroup2 BillingStatementGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementGroup2 BillingStatementGroup { get; init; } 
    #else
    public StatementGroup2 BillingStatementGroup { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since BankServicesBillingStatementV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankServicesBillingStatementV02.

