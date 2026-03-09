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
/// Identification of the place of safekeeping expressed as a code and a BIC.
/// </summary>
[IsoId("_SfoCI9p-Ed-ak6NoX_4Aeg_1628228050")]
[DisplayName("Safekeeping Place As Code And Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingPlaceAsCodeAndPartyIdentification
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingPlaceAsCodeAndPartyIdentification instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingPlaceAsCodeAndPartyIdentification( SafekeepingPlace1Code reqPlaceSafekeeping )
    {
        PlaceSafekeeping = reqPlaceSafekeeping;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_SfoCJNp-Ed-ak6NoX_4Aeg_-1275917504")]
    [DisplayName("Place Safekeeping")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcSfkpg")]
    #endif
    [IsoXmlTag("PlcSfkpg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlace1Code PlaceSafekeeping { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingPlace1Code PlaceSafekeeping { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlace1Code PlaceSafekeeping { get; init; } 
    #else
    public SafekeepingPlace1Code PlaceSafekeeping { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_SfoCJdp-Ed-ak6NoX_4Aeg_-379437396")]
    [DisplayName("Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nrrtv")]
    #endif
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Narrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Narrative { get; init; } 
    #else
    public System.String? Narrative { get; set; } 
    #endif
    
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_SfoCJtp-Ed-ak6NoX_4Aeg_-405959313")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification3? Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification3? Party { get; init; } 
    #else
    public PartyIdentification3? Party { get; set; } 
    #endif
    
    
    #nullable disable
    
}
