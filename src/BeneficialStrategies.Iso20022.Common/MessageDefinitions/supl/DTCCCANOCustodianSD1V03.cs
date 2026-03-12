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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCustodianSD1 message extends ISO corporate action notification (CANO) message with DTCC validation custodian service specific data elements that are not covered by the standard message.
/// </summary>
[Description(@"The DTCCCANOCustodianSD1 message extends ISO corporate action notification (CANO) message with DTCC validation custodian service specific data elements that are not covered by the standard message.")]
[IsoId("_1LBwZjL3EeKU9IrkkToqcw_-1345555435")]
[DisplayName("DTCCCANO Custodian SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCANOCustodianSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.004.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCtdnSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.004.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to be extended as custodian details supplementary data to corporate action notification.
    /// </summary>
    [IsoId("_1LBwZzL3EeKU9IrkkToqcw_764430494")]
    [DisplayName("Custodian Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnDtls")]
    #endif
    [IsoXmlTag("CtdnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustodianDetailsSD1? CustodianDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustodianDetailsSD1? CustodianDetails { get; init; } 
    #else
    public CustodianDetailsSD1? CustodianDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as custodian service supplementary data to option details.
    /// </summary>
    [IsoId("_1LK6UDL3EeKU9IrkkToqcw_780588655")]
    [DisplayName("Custodian Option Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnOptnDtDtls")]
    #endif
    [IsoXmlTag("CtdnOptnDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustodianOptionDateDetailsSD1? CustodianOptionDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustodianOptionDateDetailsSD1? CustodianOptionDateDetails { get; init; } 
    #else
    public CustodianOptionDateDetailsSD1? CustodianOptionDateDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCANOCustodianSD1V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCustodianSD1V03.

