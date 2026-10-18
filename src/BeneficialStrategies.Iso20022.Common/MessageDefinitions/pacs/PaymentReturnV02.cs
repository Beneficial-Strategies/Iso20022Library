// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pacs;

/// <inheritdoc cref="IPaymentReturnV02"/>
[Description(
    @"Scope|The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.|Usage|The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).|The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message ('notification') and/or BankToCustomerAccountReport/BankToCustomerStatement message ('statement').|The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.|The PaymentReturn message can be used in domestic and cross-border scenarios.|The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction."
)]
[IsoId("_eqYWKtEuEd-BzquC8wXy7w_-993933741")]
[DisplayName("Payment Return V")]
public partial record PaymentReturnV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.004.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtRtr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IPaymentReturnV02.GroupHeader"/>
    [IsoId("_eqhgANEuEd-BzquC8wXy7w_-993933711")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader38 GroupHeader { get; init; }

    /// <inheritdoc cref="IPaymentReturnV02.OriginalGroupInformation"/>
    [IsoId("_eqhgAdEuEd-BzquC8wXy7w_-993933370")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation21? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentReturnV02.TransactionInformation"/>
    [IsoId("_eqhgAtEuEd-BzquC8wXy7w_-993933649")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation27? TransactionInformation { get; init; }
}
