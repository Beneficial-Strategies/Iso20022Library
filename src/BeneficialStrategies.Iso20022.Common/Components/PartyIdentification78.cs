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
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_g-WN8IHEEeSY3ulMDfpmvA")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification78
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification78 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification78( System.String reqTradePartyIdentification )
    {
        TradePartyIdentification = reqTradePartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicate the source of the party.
    /// </summary>
    [IsoId("_6TOykIHEEeSY3ulMDfpmvA")]
    [DisplayName("Party Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtySrc")]
    #endif
    [IsoXmlTag("PtySrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IdentificationType1Code? PartySource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationType1Code? PartySource { get; init; } 
    #else
    public IdentificationType1Code? PartySource { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Hr2ZgIHFEeSY3ulMDfpmvA")]
    [DisplayName("Trade Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPtyId")]
    #endif
    [IsoXmlTag("TradPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradePartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradePartyIdentification { get; init; } 
    #else
    public System.String TradePartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
