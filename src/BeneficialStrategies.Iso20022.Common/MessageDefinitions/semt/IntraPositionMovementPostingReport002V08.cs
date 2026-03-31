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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.016.002.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IntraPositionMovementPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner.
///
/// |The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participant
/// - an agent (sub-custodian) acting on behalf of its global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage|:
/// The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|The IntraPositionMovementPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner. |||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participant|- an agent (sub-custodian) acting on behalf of its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|:|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header."
)]
[IsoId("_LTEN0wVVEeqjd8n6wD9JVw")]
[DisplayName("Intra Position Movement Posting Report 002 V")]
public record IntraPositionMovementPostingReport002V08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.016.002.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntPstngRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.016.002.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_LTEN2AVVEeqjd8n6wD9JVw")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// General information related to the report.
    /// </summary>
    [IsoId("_LTEN2gVVEeqjd8n6wD9JVw")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement81 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_LTEN3AVVEeqjd8n6wD9JVw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_LTEN3gVVEeqjd8n6wD9JVw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount30 SafekeepingAccount { get; init; }

    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_LTEN4AVVEeqjd8n6wD9JVw")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public FinancialInstrumentDetails36? FinancialInstrument { get; init; }
}

// Since IntraPositionMovementPostingReport002V08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraPositionMovementPostingReport002V08.
