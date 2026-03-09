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
/// Card programme or brand related to the transaction.
/// </summary>
[IsoId("_mv6NAEX_Eeegp_DADCe7HQ")]
[DisplayName("Card Programme")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardProgramme1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card programme or brand proposed for the transaction.
    /// </summary>
    [IsoId("_0uj5MEX_Eeegp_DADCe7HQ")]
    [DisplayName("Card Programme Proposed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrgrmmPropsd")]
    #endif
    [IsoXmlTag("CardPrgrmmPropsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProgrammeMode2? CardProgrammeProposed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProgrammeMode2? CardProgrammeProposed { get; init; } 
    #else
    public CardProgrammeMode2? CardProgrammeProposed { get; set; } 
    #endif
    
    /// <summary>
    /// Card programme or brand actually applied to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    [IsoId("_7xBZ4EYAEeegp_DADCe7HQ")]
    [DisplayName("Card Programme Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrgrmmApld")]
    #endif
    [IsoXmlTag("CardPrgrmmApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProgrammeMode1? CardProgrammeApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProgrammeMode1? CardProgrammeApplied { get; init; } 
    #else
    public CardProgrammeMode1? CardProgrammeApplied { get; set; } 
    #endif
    
    
    #nullable disable
    
}
