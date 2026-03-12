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
/// This record is an implementation of the supl.009.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_x6QSEQB6EeqouY-yI_q3qQ")]
[DisplayName("DTCCCAPASD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAPASD1V08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.08";
    
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
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_x6QSEwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD43? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD43? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD43? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_x6QSGwB6EeqouY-yI_q3qQ")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_x6QSHQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnBalDtls")]
    #endif
    [IsoXmlTag("CorpActnBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; } 
    #else
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_x6QSHwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD18? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD18? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD18? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_x6QSIQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementSecuritiesMovementDetailsSD5? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementSecuritiesMovementDetailsSD5? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionMovementSecuritiesMovementDetailsSD5? CorporateActionMovementSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_x6QSKQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementCashMovementDetailsSD5? CorporateActionMovementCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementCashMovementDetailsSD5? CorporateActionMovementCashMovementDetails { get; init; } 
    #else
    public CorporateActionMovementCashMovementDetailsSD5? CorporateActionMovementCashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_x6QSMQB6EeqouY-yI_q3qQ")]
    [DisplayName("Option Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTxDtls")]
    #endif
    [IsoXmlTag("OptnTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionTransactionDetailsSD3? OptionTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionTransactionDetailsSD3? OptionTransactionDetails { get; init; } 
    #else
    public OptionTransactionDetailsSD3? OptionTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCAPASD1V08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAPASD1V08.

