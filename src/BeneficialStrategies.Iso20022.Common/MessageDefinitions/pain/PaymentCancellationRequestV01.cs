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

namespace BeneficialStrategies.Iso20022.pain;

/// <inheritdoc cref="IPaymentCancellationRequestV01"/>
[Description(
    @"Scope|The PaymentCancellationRequest message is sent by the initiating party or any agent, to the next party in the payment chain. It is used to request the cancellation of an instruction previously sent.|Usage|The PaymentCancellationRequest message is exchanged between non-financial institution customers and agents to request the cancellation of a payment initiation message previously sent (i.e. the CustomerCreditTransferInitiation message and the CustomerDirectDebitInitiation messages).|The PaymentCancellationRequest message can be used to request the cancellation of single instructions or multiple instructions, from one or multiple files.|The PaymentCancellationRequest message can be used in domestic and cross-border scenarios.|The PaymentCancellationRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The PaymentCancellationRequest message exchanged between non-financial institution customers and agents is identified in the schema as follows: urn:iso:std:iso:20022:tech:xsd:pain.006.001.01."
)]
[IsoId("_GZHVINEvEd-BzquC8wXy7w_162316323")]
[DisplayName("Payment Cancellation Request V")]
public partial record PaymentCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.006.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pain.006.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.006.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IPaymentCancellationRequestV01.GroupHeader"/>
    [IsoId("_GZQfENEvEd-BzquC8wXy7w_162316362")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader7 GroupHeader { get; init; }

    /// <inheritdoc cref="IPaymentCancellationRequestV01.OriginalGroupInformation"/>
    [IsoId("_GZQfEdEvEd-BzquC8wXy7w_162316385")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation4 OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentCancellationRequestV01.TransactionInformation"/>
    [IsoId("_GZQfEtEvEd-BzquC8wXy7w_162316416")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation3? TransactionInformation { get; init; }
}
