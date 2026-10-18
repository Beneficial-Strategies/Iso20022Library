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

/// <inheritdoc cref="ICustomerPaymentReversalV12"/>
[IsoId("_R3H8YTEZEe6kQ-WGAhcVPQ")]
[DisplayName("Customer Payment Reversal V12")]
public partial record CustomerPaymentReversalV12 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.12";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pain.007.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.12";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="ICustomerPaymentReversalV12.GroupHeader"/>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader124 GroupHeader { get; init; }

    /// <inheritdoc cref="ICustomerPaymentReversalV12.OriginalGroupInformation"/>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupHeader20 OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="ICustomerPaymentReversalV12.OriginalPaymentInformationAndReversal"/>
    [DisplayName("Original Payment Information And Reversal")]
    [IsoXmlTag("OrgnlPmtInfAndRvsl")]
    public ValueList<OriginalPaymentInstruction50> OriginalPaymentInformationAndReversal { get; init; } =
        [];

    /// <inheritdoc cref="ICustomerPaymentReversalV12.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
