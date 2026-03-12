// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCorrection message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to correct at least one of the prices for a financial instrument that was reported in a previously sent PriceReport message.
/// Usage
/// The PriceReportCorrection message is used to correct information reported in a previously sent PriceReport.
/// If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport sent.
/// </summary>
[Description(@"Scope|A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCorrection message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to correct at least one of the prices for a financial instrument that was reported in a previously sent PriceReport message.|Usage|The PriceReportCorrection message is used to correct information reported in a previously sent PriceReport.|If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport sent.")]
[IsoId("_ZtBOz9EvEd-BzquC8wXy7w_-770509177")]
[DisplayName("Price Report Correction V")]
public partial record PriceReportCorrectionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCrrctnV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_ZtBO0NEvEd-BzquC8wXy7w_1796163719")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZtKYsNEvEd-BzquC8wXy7w_133617453")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_ZtKYsdEvEd-BzquC8wXy7w_144699623")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_ZtKYstEvEd-BzquC8wXy7w_-1002757457")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// Information related to the correction of a price of a financial instrument.
    /// </summary>
    [IsoId("_ZtKYs9EvEd-BzquC8wXy7w_1468107589")]
    [DisplayName("Price Correction Details")]
    [IsoXmlTag("PricCrrctnDtls")]
    public required PriceCorrection3 PriceCorrectionDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since PriceReportCorrectionV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCorrectionV03.

