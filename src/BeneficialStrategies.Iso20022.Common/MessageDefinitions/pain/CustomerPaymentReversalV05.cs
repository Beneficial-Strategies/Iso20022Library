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

/// <inheritdoc cref="ICustomerPaymentReversalV05"/>
[Description(
    @"Scope|The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.|The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentReversal message can be used in domestic and cross-border scenarios."
)]
[IsoId("_NasXRRPeEeSVo-TFVwFHvA")]
[DisplayName("Customer Payment Reversal V")]
public partial record CustomerPaymentReversalV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtRvsl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="ICustomerPaymentReversalV05.GroupHeader"/>
    [IsoId("_NasXURPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader56 GroupHeader { get; init; }

    /// <inheritdoc cref="ICustomerPaymentReversalV05.OriginalGroupInformation"/>
    [IsoId("_NasXUxPeEeSVo-TFVwFHvA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupHeader3 OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="ICustomerPaymentReversalV05.OriginalPaymentInformationAndReversal"/>
    [IsoId("_NasXVRPeEeSVo-TFVwFHvA")]
    [DisplayName("Original Payment Information And Reversal")]
    [IsoXmlTag("OrgnlPmtInfAndRvsl")]
    public OriginalPaymentInstruction11? OriginalPaymentInformationAndReversal { get; init; }

    /// <inheritdoc cref="ICustomerPaymentReversalV05.SupplementaryData"/>
    [IsoId("_NasXVxPeEeSVo-TFVwFHvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
