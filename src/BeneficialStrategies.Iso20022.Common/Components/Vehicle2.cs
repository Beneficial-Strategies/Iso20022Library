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
/// Additional information related to a vehicle.
/// </summary>
[IsoId("_nC2q8ZdOEeWhUvuI1bSHSA")]
[DisplayName("Vehicle")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vehicle2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vehicle2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vehicle2( System.String reqData )
    {
        Data = reqData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of information related to the vehicle.
    /// </summary>
    [IsoId("_4aiIcJdOEeWhUvuI1bSHSA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the information.
    /// </summary>
    [IsoId("_nN4PN5dOEeWhUvuI1bSHSA")]
    [DisplayName("Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryMd")]
    #endif
    [IsoXmlTag("NtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading5Code? EntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading5Code? EntryMode { get; init; } 
    #else
    public CardDataReading5Code? EntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the vehicle.
    /// </summary>
    [IsoId("_nN4PSZdOEeWhUvuI1bSHSA")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Data { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Data { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Data { get; init; } 
    #else
    public System.String Data { get; set; } 
    #endif
    
    
    #nullable disable
    
}
