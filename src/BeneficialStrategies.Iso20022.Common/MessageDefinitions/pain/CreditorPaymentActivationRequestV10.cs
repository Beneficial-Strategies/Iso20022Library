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

/// <inheritdoc cref="ICreditorPaymentActivationRequestV10"/>
[Description(
    @"The CreditorPaymentActivationRequest message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents. It is used by a Creditor to request movement of funds from the debtor account to a creditor."
)]
[IsoId("_XXWvgQLFEe2X55dNQNVKfg")]
[DisplayName("Creditor Payment Activation Request V")]
public partial record CreditorPaymentActivationRequestV10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.013.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.013.001.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="ICreditorPaymentActivationRequestV10.GroupHeader"/>
    [IsoId("_XXWvkQLFEe2X55dNQNVKfg")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader105 GroupHeader { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestV10.PaymentInformation"/>
    [IsoId("_XXWvkwLFEe2X55dNQNVKfg")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    public required PaymentInstruction42 PaymentInformation { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestV10.SupplementaryData"/>
    [IsoId("_XXWvlQLFEe2X55dNQNVKfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
