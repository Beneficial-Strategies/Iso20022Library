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
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_TXznW9p-Ed-ak6NoX_4Aeg_-1470635815")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_TXznXNp-Ed-ak6NoX_4Aeg_-1111386502")]
    [DisplayName("Proposed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdRate")]
    #endif
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ProposedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ProposedRate { get; init; } 
    #else
    public System.Decimal? ProposedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_TX8xQNp-Ed-ak6NoX_4Aeg_-856494647")]
    [DisplayName("Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptRate")]
    #endif
    [IsoXmlTag("OvrsbcptRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat12Choice_? OversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat12Choice_? OversubscriptionRate { get; init; } 
    #else
    public RateAndAmountFormat12Choice_? OversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Requested tax rate in case of breakdown of tax rate, for example, used for adjustment of tax rate. This is the new requested applicable rate.
    /// </summary>
    [IsoId("_TX8xQdp-Ed-ak6NoX_4Aeg_-802008412")]
    [DisplayName("Requested Taxation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTaxtnRate")]
    #endif
    [IsoXmlTag("ReqdTaxtnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RequestedTaxationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RequestedTaxationRate { get; init; } 
    #else
    public System.Decimal? RequestedTaxationRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
