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
/// Identification of the type of place of safekeeping expressed as a code and a BIC.
/// </summary>
[IsoId("_Wjinw7XEEeiTob_PrFFUxA")]
[DisplayName("Safekeeping Place Type And Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingPlaceTypeAndIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingPlaceTypeAndIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingPlaceTypeAndIdentification1( SafekeepingPlace1Code reqSafekeepingPlaceType,System.String reqIdentification )
    {
        SafekeepingPlaceType = reqSafekeepingPlaceType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_W1QC0bXEEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Place Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlcTp")]
    #endif
    [IsoXmlTag("SfkpgPlcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
    #else
    public SafekeepingPlace1Code SafekeepingPlaceType { get; set; } 
    #endif
    
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_W1QC07XEEeiTob_PrFFUxA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICDec2014Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
