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
/// This record is an implementation of the supl.007.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.")]
[IsoId("_q_pKdQ4zEeuIpNw_GxsBOw")]
[DisplayName("DTCCCANO Eligible Balance SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCANOEligibleBalanceSD1V10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.007.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOElgblBalSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.007.001.10";
    
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
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_q_pKdw4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD42? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD42? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD42? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_q_pKeQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD21? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to account balance for distribution events.
    /// </summary>
    [IsoId("_q_pKew4zEeuIpNw_GxsBOw")]
    [DisplayName("Distribution Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnAcctBal")]
    #endif
    [IsoXmlTag("DstrbtnAcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD10? DistributionAccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD10? DistributionAccountBalance { get; init; } 
    #else
    public AccountBalanceSD10? DistributionAccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to account balance for redemptions events.
    /// </summary>
    [IsoId("_q_pKfQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Redemption Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedAcctBal")]
    #endif
    [IsoXmlTag("RedAcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD11? RedemptionAccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD11? RedemptionAccountBalance { get; init; } 
    #else
    public AccountBalanceSD11? RedemptionAccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to account balance for reorganisation events.
    /// </summary>
    [IsoId("_q_pKfw4zEeuIpNw_GxsBOw")]
    [DisplayName("Reorganisation Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReorgAcctBal")]
    #endif
    [IsoXmlTag("ReorgAcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalanceSD12? ReorganisationAccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalanceSD12? ReorganisationAccountBalance { get; init; } 
    #else
    public AccountBalanceSD12? ReorganisationAccountBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCANOEligibleBalanceSD1V10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOEligibleBalanceSD1V10.

