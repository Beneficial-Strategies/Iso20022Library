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



namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_1NQlAzL3EeKU9IrkkToqcw_389560889")]
[DisplayName("DTCCCACOSD 1 V")]
public partial record DTCCCACOSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.01";
    
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
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_1NQlBDL3EeKU9IrkkToqcw_-424160834")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD1? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_1NQlBTL3EeKU9IrkkToqcw_-1746121200")]
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    public CorporateActionConfirmationSecuritiesMovementDetailsSD1? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_1NQlBjL3EeKU9IrkkToqcw_-419706544")]
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    public CorporateActionConfirmationCashMovementDetailsSD1? CorporateActionConfirmationCashMovementDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCACOSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACOSD1V01.

