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
/// Identification of a settlement party.
/// </summary>
[IsoId("_9DljPYftEeevKP8c-ilVhA")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount156
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount156 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount156( PartyIdentification113 reqPlaceOfSettlement )
    {
        PlaceOfSettlement = reqPlaceOfSettlement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_9UshMYftEeevKP8c-ilVhA")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? PartyIdentification { get; init; } 
    #else
    public PartyIdentification113? PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_9UshM4ftEeevKP8c-ilVhA")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_9UshNYftEeevKP8c-ilVhA")]
    [DisplayName("Place Of Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlm")]
    #endif
    [IsoXmlTag("PlcOfSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification113 PlaceOfSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification113 PlaceOfSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113 PlaceOfSettlement { get; init; } 
    #else
    public PartyIdentification113 PlaceOfSettlement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
