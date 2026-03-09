// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the clearing details.
/// </summary>
[IsoId("_tv6MUWpUEeSgo9vJrfSF_Q")]
[DisplayName("Clearing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Clearing4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Clearing4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Clearing4( NettingEligible1Code reqSettlementNettingEligibleCode )
    {
        SettlementNettingEligibleCode = reqSettlementNettingEligibleCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates to the clearing member whether the trade is eligible for settlement netting or not.
    /// </summary>
    [IsoId("_uM64c2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Settlement Netting Eligible Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmNetgElgblCd")]
    #endif
    [IsoXmlTag("SttlmNetgElgblCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingEligible1Code SettlementNettingEligibleCode { get; init; } 
    #else
    public NettingEligible1Code SettlementNettingEligibleCode { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_uM64dWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Clearing Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSgmt")]
    #endif
    [IsoXmlTag("ClrSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #else
    public PartyIdentification35Choice_? ClearingSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the position is guaranteed or non-guaranteed by the central counterparty, that is whether the CCP has done the novation and then guarantees the trade, or not.
    /// </summary>
    [IsoId("_uM64d2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Guaranteed Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedTrad")]
    #endif
    [IsoXmlTag("GrntedTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? GuaranteedTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GuaranteedTrade { get; init; } 
    #else
    public System.String? GuaranteedTrade { get; set; } 
    #endif
    
    /// <summary>
    /// In case of trades that are not guaranteed by the central counterparty (this is when the central counterparty has not done the novation), provides details such as the trade counterparty member identification or the trade counterparty clearing member identification.
    /// </summary>
    [IsoId("_uM64eWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Non Guaranteed Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonGrntedTrad")]
    #endif
    [IsoXmlTag("NonGrntedTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; init; } 
    #else
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; set; } 
    #endif
    
    
    #nullable disable
    
}
