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
/// This record is an implementation of the auth.085.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the CCP-cleared securities financing transactions.
/// </summary>
[Description(@"The SecuritiesFinancingReportingMarginDataTransactionStateReport message is sent by the trade repository (TR) to the competent authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the margins exchanged in relation to the CCP-cleared securities financing transactions.")]
[IsoId("_WA-jUcKuEeuzU9S_IANlog")]
[DisplayName("Securities Financing Reporting Margin Data Transaction State Report V")]
public partial record SecuritiesFinancingReportingMarginDataTransactionStateReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.085.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgMrgnDataTxStatRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.085.001.02";
    
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
    /// Set of information related to trade state reporting.
    /// </summary>
    [IsoId("_WA-jU8KuEeuzU9S_IANlog")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData38Choice_ TradeData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_WA-jVcKuEeuzU9S_IANlog")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SecuritiesFinancingReportingMarginDataTransactionStateReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingReportingMarginDataTransactionStateReportV02.

