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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.109.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the derivatives transactions.
/// </summary>
[Description(@"The DerivativesTradeMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the derivatives transactions.")]
[IsoId("_pVVvgWmFEe2DRvVJM2Qy-g")]
[DisplayName("Derivatives Trade Margin Data Transaction State Report V")]
public partial record DerivativesTradeMarginDataTransactionStateReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.109.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradMrgnDataTxStatRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.109.001.01";
    
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
    /// Header information related to metadata of report message.
    /// </summary>
    [IsoId("_pVVvg2mFEe2DRvVJM2Qy-g")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required TradeReportHeader4 ReportHeader { get; init; } 
    
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [IsoId("_pVVvhWmFEe2DRvVJM2Qy-g")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData56Choice_ TradeData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVVvh2mFEe2DRvVJM2Qy-g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since DerivativesTradeMarginDataTransactionStateReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeMarginDataTransactionStateReportV01.

