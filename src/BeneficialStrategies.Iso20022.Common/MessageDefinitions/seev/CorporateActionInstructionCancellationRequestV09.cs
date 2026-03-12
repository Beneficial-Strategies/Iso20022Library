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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.040.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstructionCancellationRequest message is sent by an account owner to an account servicer to request cancellation of a previously sent corporate action election instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionInstructionCancellationRequest message is sent by an account owner to an account servicer to request cancellation of a previously sent corporate action election instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_hptEs-XjEemEj48jhmlA0Q")]
[DisplayName("Corporate Action Instruction Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructionCancellationRequestV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.040.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.040.001.09";
    
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
    /// <summary>
    /// Constructs a CorporateActionInstructionCancellationRequestV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructionCancellationRequestV09( DocumentIdentification31 reqInstructionIdentification,CorporateActionGeneralInformation139 reqCorporateActionGeneralInformation,AccountIdentification46 reqAccountDetails,CorporateActionOption166 reqCorporateActionInstruction )
    {
        InstructionIdentification = reqInstructionIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        CorporateActionInstruction = reqCorporateActionInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_hptEv-XjEemEj48jhmlA0Q")]
    [DisplayName("Change Instruction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngInstrInd")]
    #endif
    [IsoXmlTag("ChngInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChangeInstructionIndicator { get; init; } 
    #else
    public System.String? ChangeInstructionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent instruction document.
    /// </summary>
    [IsoId("_hptEweXjEemEj48jhmlA0Q")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification31 InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification31 InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31 InstructionIdentification { get; init; } 
    #else
    public DocumentIdentification31 InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_hptEw-XjEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation139 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation139 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation139 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation139 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_hptExeXjEemEj48jhmlA0Q")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification46 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification46 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification46 AccountDetails { get; init; } 
    #else
    public AccountIdentification46 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_hptEx-XjEemEj48jhmlA0Q")]
    [DisplayName("Corporate Action Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnInstr")]
    #endif
    [IsoXmlTag("CorpActnInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption166 CorporateActionInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption166 CorporateActionInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption166 CorporateActionInstruction { get; init; } 
    #else
    public CorporateActionOption166 CorporateActionInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_hptEyeXjEemEj48jhmlA0Q")]
    [DisplayName("Protect Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctInstr")]
    #endif
    [IsoXmlTag("PrtctInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectInstruction3? ProtectInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectInstruction3? ProtectInstruction { get; init; } 
    #else
    public ProtectInstruction3? ProtectInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_hptEy-XjEemEj48jhmlA0Q")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CorporateActionInstructionCancellationRequestV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstructionCancellationRequestV09.

