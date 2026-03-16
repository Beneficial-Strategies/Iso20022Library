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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider, sends the FundProcessingPassportReport message to the report recipient, for, a professional investor, investment fund distributor, market data provider, regulator or other interested party to provide the key reference data for financial instruments to facilitate trading.
/// Usage
/// A unique FundProcessingPassportReport should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its &quot;home&quot; market.
/// The FundProcessingPassportReport may be used in various models or environments:
/// - stand alone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.
/// - in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.
/// - in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund processing passport information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.
/// </summary>
[Description(
    @"Scope|A report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider, sends the FundProcessingPassportReport message to the report recipient, for, a professional investor, investment fund distributor, market data provider, regulator or other interested party to provide the key reference data for financial instruments to facilitate trading.|Usage|A unique FundProcessingPassportReport should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its ""home"" market.|The FundProcessingPassportReport may be used in various models or environments:|- stand alone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.|- in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.|- in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund processing passport information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user."
)]
[IsoId("_ZsRA2NEvEd-BzquC8wXy7w_2012426718")]
[DisplayName("Fund Processing Passport Report V")]
public record FundProcessingPassportReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.004.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndPrcgPsptRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.004.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_ZsRA2dEvEd-BzquC8wXy7w_1111943337")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    ///  Fund Processing Passsport (FPP) is a fully harmonised document with all key operational information that fund promoters
    ///  should provide on their investment funds in order to facilitate their trading.
    /// </summary>
    [IsoId("_ZsRA2tEvEd-BzquC8wXy7w_-23910655")]
    [DisplayName("Fund Processing Passport")]
    [IsoXmlTag("FPP")]
    public required FundProcessingPassport1 FundProcessingPassport { get; init; }
}

// Since FundProcessingPassportReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundProcessingPassportReportV02.
