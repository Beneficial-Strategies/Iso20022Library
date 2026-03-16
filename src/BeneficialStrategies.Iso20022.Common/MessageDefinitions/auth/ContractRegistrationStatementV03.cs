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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.022.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ContractRegistrationStatement message is sent by the registration agent to the reporting party, in response to a request or at a pre-agreed date, to send a statement of the operations related to the registered contract subject to currency control.
/// </summary>
[Description(
    @"The ContractRegistrationStatement message is sent by the registration agent to the reporting party, in response to a request or at a pre-agreed date, to send a statement of the operations related to the registered contract subject to currency control."
)]
[IsoId("_Nz8arx3pEeuiRvbpCaJe6A")]
[DisplayName("Contract Registration Statement V")]
public record ContractRegistrationStatementV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.022.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtrctRegnStmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.022.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8asR3pEeuiRvbpCaJe6A")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required CurrencyControlHeader6 GroupHeader { get; init; }

    /// <summary>
    /// Provides the contract registration statement, which includes all journals on the activities related to the contract.
    /// </summary>
    [IsoId("_Nz8asx3pEeuiRvbpCaJe6A")]
    [DisplayName("Statement")]
    [IsoXmlTag("Stmt")]
    public required ContractRegistrationStatement3 Statement { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8atR3pEeuiRvbpCaJe6A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ContractRegistrationStatementV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ContractRegistrationStatementV03.
