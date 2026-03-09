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
/// Contract cession data in structured form.
/// </summary>
[IsoId("_qkawwLb-Eeu9Cp6InX88Vw")]
[DisplayName("Contract Cession Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractCessionData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractCessionData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractCessionData1( TradeParty5 reqParty )
    {
        Party = reqParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The party to which the cession is made.
    /// </summary>
    [IsoId("_ON5xsLb_Eeu9Cp6InX88Vw")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty5 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty5 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty5 Party { get; init; } 
    #else
    public TradeParty5 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the document under which the cession is made.
    /// </summary>
    [IsoId("_YPJNILb_Eeu9Cp6InX88Vw")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DocumentNumber { get; init; } 
    #else
    public System.String? DocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the document under which the cession is made.
    /// </summary>
    [IsoId("_begFELb_Eeu9Cp6InX88Vw")]
    [DisplayName("Document Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocDt")]
    #endif
    [IsoXmlTag("DocDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DocumentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DocumentDate { get; init; } 
    #else
    public System.DateOnly? DocumentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
