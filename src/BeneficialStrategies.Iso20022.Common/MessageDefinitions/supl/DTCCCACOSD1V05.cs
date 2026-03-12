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
/// This record is an implementation of the supl.011.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_I7vsrZCEEeaSk9d1hvTrHg")]
[DisplayName("DTCCCACOSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCACOSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.011.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.05";
    
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
    /// Page number of the message and continuation indicator to indicate that the multi-parts confirmation is to continue or that the message is the last page of the multi-parts confirmation.
    /// </summary>
    [IsoId("_3HceIZE_EeanIpS4qvJ1tw")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_I7vsr5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD27? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD27? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD27? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7wTsZCEEeaSk9d1hvTrHg")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I7wTs5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD16? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD16? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD16? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_I7wTtZCEEeaSk9d1hvTrHg")]
    [DisplayName("Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBal")]
    #endif
    [IsoXmlTag("AcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD9? AccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD9? AccountBalance { get; init; } 
    #else
    public AccountBalanceSD9? AccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action confirmation details.
    /// </summary>
    [IsoId("_4yXyEJFDEeanIpS4qvJ1tw")]
    [DisplayName("Corporate Action Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfDtls")]
    #endif
    [IsoXmlTag("CorpActnConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationDetailsSD1? CorporateActionConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationDetailsSD1? CorporateActionConfirmationDetails { get; init; } 
    #else
    public CorporateActionConfirmationDetailsSD1? CorporateActionConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_I7wTt5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Confirmation Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationSecuritiesMovementDetailsSD5? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationSecuritiesMovementDetailsSD5? CorporateActionConfirmationSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationSecuritiesMovementDetailsSD5? CorporateActionConfirmationSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_I7wTv5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Confirmation Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnConfCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionConfirmationCashMovementDetailsSD4? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionConfirmationCashMovementDetailsSD4? CorporateActionConfirmationCashMovementDetails { get; init; } 
    #else
    public CorporateActionConfirmationCashMovementDetailsSD4? CorporateActionConfirmationCashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_MrdVAZFHEeanIpS4qvJ1tw")]
    [DisplayName("Option Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTxDtls")]
    #endif
    [IsoXmlTag("OptnTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionTransactionDetailsSD2? OptionTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionTransactionDetailsSD2? OptionTransactionDetails { get; init; } 
    #else
    public OptionTransactionDetailsSD2? OptionTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCACOSD1V05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACOSD1V05.

