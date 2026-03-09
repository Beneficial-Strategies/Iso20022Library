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
/// Provides additional information such as the information to comply with.
/// </summary>
[IsoId("_ULqGIdp-Ed-ak6NoX_4Aeg_-819428560")]
[DisplayName("Corporate Action Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or Sophisticated Investor Letter (SIL) to be provided.
    /// </summary>
    [IsoId("_ULqGItp-Ed-ak6NoX_4Aeg_-819427827")]
    [DisplayName("Information To Comply With")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfToCmplyWth")]
    #endif
    [IsoXmlTag("InfToCmplyWth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InformationToComplyWith { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InformationToComplyWith { get; init; } 
    #else
    public System.String? InformationToComplyWith { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the delivery details of the outturned (derived) securities. This narrative is only to be used in case the securities are not eligible at the agent/custodian, and may not be used for settlement instructions.
    /// </summary>
    [IsoId("_ULqGI9p-Ed-ak6NoX_4Aeg_-819427785")]
    [DisplayName("Delivery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDtls")]
    #endif
    [IsoXmlTag("DlvryDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DeliveryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryDetails { get; init; } 
    #else
    public System.String? DeliveryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_ULqGJNp-Ed-ak6NoX_4Aeg_-819427767")]
    [DisplayName("Foreign Exchange Instructions Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXInstrsAddtlInf")]
    #endif
    [IsoXmlTag("FXInstrsAddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ForeignExchangeInstructionsAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForeignExchangeInstructionsAdditionalInformation { get; init; } 
    #else
    public System.String? ForeignExchangeInstructionsAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Disclaimer relative to the information provided in the message. It may be ignored for automated processing. No information about the instruction itself is allowed here.
    /// </summary>
    [IsoId("_ULqGJdp-Ed-ak6NoX_4Aeg_-819427707")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Disclaimer { get; init; } 
    #else
    public System.String? Disclaimer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to the corporate action instruction.
    /// </summary>
    [IsoId("_ULqGJtp-Ed-ak6NoX_4Aeg_-819427690")]
    [DisplayName("Instruction Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrAddtlInf")]
    #endif
    [IsoXmlTag("InstrAddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionAdditionalInformation { get; init; } 
    #else
    public System.String? InstructionAdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
