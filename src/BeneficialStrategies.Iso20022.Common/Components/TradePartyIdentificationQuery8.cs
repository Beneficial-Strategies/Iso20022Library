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
/// Query of a trade party based on the identification.
/// </summary>
[IsoId("_FHEpEZQTEeiok48Eh9lW9Q")]
[DisplayName("Trade Party Identification Query")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyIdentificationQuery8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_FS0mEZQTEeiok48Eh9lW9Q")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Business identifier code used to identify the trade party.
    /// </summary>
    [IsoId("_FS0mE5QTEeiok48Eh9lW9Q")]
    [DisplayName("Any BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnyBIC")]
    #endif
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AnyBIC { get; init; } 
    #else
    public System.String? AnyBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the client counterparty.
    /// </summary>
    [IsoId("_FS0mFZQTEeiok48Eh9lW9Q")]
    [DisplayName("Client Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntId")]
    #endif
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? ClientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientIdentification { get; init; } 
    #else
    public System.String? ClientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_FS0mF5QTEeiok48Eh9lW9Q")]
    [DisplayName("Not Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotRptd")]
    #endif
    [IsoXmlTag("NotRptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotReported1Code? NotReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotReported1Code? NotReported { get; init; } 
    #else
    public NotReported1Code? NotReported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
