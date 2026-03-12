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



namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DefaultFundContributionReport message is sent by the central counterparty (CCP) to a Clearing member to report on the calculation of the default fund contribution and the potential net excess or deficit.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// CCPs require participants to post assets in a clearing fund that can be used in the event of a default by a participant, to compensate non-defaulting participants for losses they suffer due to this default. The CCP evaluates each participant risk level based on their positions (monthly or daily) and calculate the excess of deficit of the default fund contribution. The DefaultFundContributionReport is usually sent on a monthly basis.
/// </summary>
[Description(@"Scope|The DefaultFundContributionReport message is sent by the central counterparty (CCP) to a Clearing member to report on the calculation of the default fund contribution and the potential net excess or deficit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|CCPs require participants to post assets in a clearing fund that can be used in the event of a default by a participant, to compensate non-defaulting participants for losses they suffer due to this default. The CCP evaluates each participant risk level based on their positions (monthly or daily) and calculate the excess of deficit of the default fund contribution. The DefaultFundContributionReport is usually sent on a monthly basis.")]
[IsoId("_-hesiaMOEeCojJW5vEuTEQ_-1558125935")]
[DisplayName("Default Fund Contribution Report V")]
public partial record DefaultFundContributionReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DfltFndCntrbtnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.006.001.02";
    
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
    /// Provides details about the report such as the report identification, the calculation date, the value date.
    /// </summary>
    [IsoId("_-hesiqMOEeCojJW5vEuTEQ_-2028070464")]
    [DisplayName("Report Parameters")]
    [IsoXmlTag("RptParams")]
    public required ReportParameters2 ReportParameters { get; init; } 
    
    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_-hesi6MOEeCojJW5vEuTEQ_2103498306")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    
    /// <summary>
    /// Provides details on the default fund report.
    /// </summary>
    [IsoId("_-hodgKMOEeCojJW5vEuTEQ_-78589152")]
    [DisplayName("Report Details")]
    [IsoXmlTag("RptDtls")]
    public required DefaultFundReport1 ReportDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-hodgaMOEeCojJW5vEuTEQ_-1828123252")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since DefaultFundContributionReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DefaultFundContributionReportV02.

