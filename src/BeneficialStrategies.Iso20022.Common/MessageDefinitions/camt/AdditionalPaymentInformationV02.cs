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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.028.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_FuEPONE-Ed-BzquC8wXy7w_-432637139")]
[DisplayName("Additional Payment Information V02")]
public record AdditionalPaymentInformationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.028.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AddtlPmtInf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.028.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Assignment.
    /// </summary>
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment Assignment { get; init; }

    /// <summary>
    /// Case.
    /// </summary>
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case Case { get; init; }

    /// <summary>
    /// Information.
    /// </summary>
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    public required PaymentComplementaryInformation Information { get; init; }

    /// <summary>
    /// Underlying.
    /// </summary>
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required PaymentInstructionExtract2 Underlying { get; init; }
}

// Since AdditionalPaymentInformationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AdditionalPaymentInformationV02.
