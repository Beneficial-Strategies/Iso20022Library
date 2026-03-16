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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.041.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// |An account owner sends a BuyInRegulatoryAdvice to an account servicer to  notify the results of the buy-in transactions executed under CSDR regulatory regime.||
/// The account owner/servicer relationship may be:|- a central securities depository participant which has an account with a central securities depository.|It could also be, if agreed in a service level agreement:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|The ultimate receiving party at the end of the settlement chain is a central securities depository or interational central securities depository.||
///
/// Usage
/// |The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.||
/// </summary>
[Description(
    @"Scope||An account owner sends a BuyInRegulatoryAdvice to an account servicer to  notify the results of the buy-in transactions executed under CSDR regulatory regime.|||The account owner/servicer relationship may be:|- a central securities depository participant which has an account with a central securities depository.|It could also be, if agreed in a service level agreement:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|The ultimate receiving party at the end of the settlement chain is a central securities depository or interational central securities depository.||||Usage||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.||"
)]
[IsoId("_O1mdgZwQEeqtp-LOti013g")]
[DisplayName("Buy In Regulatory Advice V")]
public record BuyInRegulatoryAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.041.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRgltryAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.041.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_O1mdiZwQEeqtp-LOti013g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account used in the original failing transaction.
    /// </summary>
    [IsoId("_O1mdi5wQEeqtp-LOti013g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Details of the buy-in.
    /// </summary>
    [IsoId("_O1mdjZwQEeqtp-LOti013g")]
    [DisplayName("Buy In Attributes")]
    [IsoXmlTag("BuyInAttrbts")]
    public required BuyInAdviceDetails1 BuyInAttributes { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_O1mdkZwQEeqtp-LOti013g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since BuyInRegulatoryAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInRegulatoryAdviceV01.
