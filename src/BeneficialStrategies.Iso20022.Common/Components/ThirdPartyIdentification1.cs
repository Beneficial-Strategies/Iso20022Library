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
/// Identification of the third party.
/// </summary>
[IsoId("_iumBkPQ-EeqAradXpAelDQ")]
[DisplayName("Third Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ThirdPartyIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ThirdPartyIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ThirdPartyIdentification1( PartyRole3Code reqRole )
    {
        Role = reqRole;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Role played by the third party.
    /// </summary>
    [IsoId("_q9sxAPQ-EeqAradXpAelDQ")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyRole3Code Role { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyRole3Code Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyRole3Code Role { get; init; } 
    #else
    public PartyRole3Code Role { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the third party legal entity.
    /// </summary>
    [IsoId("_xOpKoPQ-EeqAradXpAelDQ")]
    [DisplayName("Legal Person Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglPrsnId")]
    #endif
    [IsoXmlTag("LglPrsnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification221? LegalPersonIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification221? LegalPersonIdentification { get; init; } 
    #else
    public PartyIdentification221? LegalPersonIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
