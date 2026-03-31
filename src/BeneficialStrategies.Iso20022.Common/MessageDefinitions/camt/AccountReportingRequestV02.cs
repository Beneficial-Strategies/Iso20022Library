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
/// This record is an implementation of the camt.060.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner&apos;s account in a BankToCustomerAccountReport (camt.052.001.02), a BankToCustomerStatement (camt.053.001.02) or a BankToCustomerDebitCreditNotification (camt.054.001.02).
/// Usage
/// The AccountReportingRequest message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.
/// </summary>
[Description(
    @"Scope|The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner's account in a BankToCustomerAccountReport (camt.052.001.02), a BankToCustomerStatement (camt.053.001.02) or a BankToCustomerDebitCreditNotification (camt.054.001.02).|Usage|The AccountReportingRequest message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario."
)]
[IsoId("_sd2raGtdEeCY4-KZ9JEyUQ_1430848689")]
[DisplayName("Account Reporting Request V")]
public record AccountReportingRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.060.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRptgReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.060.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_sd2raWtdEeCY4-KZ9JEyUQ_1191907994")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader43 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to provide further details on the reporting request.
    /// </summary>
    [IsoId("_seAcYGtdEeCY4-KZ9JEyUQ_308674707")]
    [DisplayName("Reporting Request")]
    [IsoXmlTag("RptgReq")]
    public required ReportingRequest2 ReportingRequest { get; init; }
}

// Since AccountReportingRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountReportingRequestV02.
