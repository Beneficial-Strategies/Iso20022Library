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
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
[IsoId("_Wh3IiNp-Ed-ak6NoX_4Aeg_51306419")]
[DisplayName("Party Text Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyTextInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    [IsoId("_Wh3Iidp-Ed-ak6NoX_4Aeg_-1942838287")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclarationDetails { get; init; } 
    #else
    public System.String? DeclarationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_Wh3Iitp-Ed-ak6NoX_4Aeg_1241217590")]
    [DisplayName("Party Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyCtctDtls")]
    #endif
    [IsoXmlTag("PtyCtctDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? PartyContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyContactDetails { get; init; } 
    #else
    public System.String? PartyContactDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
