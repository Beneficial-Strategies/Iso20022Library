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
/// Information about hold back and gating.
/// </summary>
[IsoId("_i4Ff4TwvEeaFzejt0Yw_3A")]
[DisplayName("Hold Back Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HoldBackInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HoldBackInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HoldBackInformation2( GateHoldBack1Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [IsoId("_wtS8MDwvEeaFzejt0Yw_3A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GateHoldBack1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GateHoldBack1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GateHoldBack1Code Type { get; init; } 
    #else
    public GateHoldBack1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [IsoId("_jQ7dsTwvEeaFzejt0Yw_3A")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [IsoId("_jQ7dszwvEeaFzejt0Yw_3A")]
    [DisplayName("Expected Release Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdRlsDt")]
    #endif
    [IsoXmlTag("XpctdRlsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedReleaseDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedReleaseDate { get; init; } 
    #else
    public System.DateOnly? ExpectedReleaseDate { get; set; } 
    #endif
    
    /// <summary>
    /// New identification of the security.
    /// </summary>
    [IsoId("_cbKDQTwwEeaFzejt0Yw_3A")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New name of the security.
    /// </summary>
    [IsoId("_nRyOlDwwEeaFzejt0Yw_3A")]
    [DisplayName("Financial Instrument Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmNm")]
    #endif
    [IsoXmlTag("FinInstrmNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FinancialInstrumentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinancialInstrumentName { get; init; } 
    #else
    public System.String? FinancialInstrumentName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [IsoId("_vdxYkDwwEeaFzejt0Yw_3A")]
    [DisplayName("Redemption Completion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedCmpltn")]
    #endif
    [IsoXmlTag("RedCmpltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; } 
    #else
    public RedemptionCompletion1Code? RedemptionCompletion { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not this is the final redemption confirmation in the execution of a gated redemption.
    /// </summary>
    [IsoId("_PE9owDwxEeaFzejt0Yw_3A")]
    [DisplayName("Final Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlConf")]
    #endif
    [IsoXmlTag("FnlConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FinalConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinalConfirmation { get; init; } 
    #else
    public System.String? FinalConfirmation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
