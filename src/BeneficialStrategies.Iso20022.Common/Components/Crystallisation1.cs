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
/// Number of crystallised units.
/// </summary>
[IsoId("_PzGf8E3gEeidB49bWZiS0g")]
[DisplayName("Crystallisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Crystallisation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Crystallisation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Crystallisation1( System.String reqTrancheIdentification )
    {
        TrancheIdentification = reqTrancheIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the tranche.
    /// </summary>
    [IsoId("_XvKXkE3gEeidB49bWZiS0g")]
    [DisplayName("Tranche Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrchId")]
    #endif
    [IsoXmlTag("TrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TrancheIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TrancheIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TrancheIdentification { get; init; } 
    #else
    public System.String TrancheIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units crystallised.
    /// </summary>
    [IsoId("_erZw8E3gEeidB49bWZiS0g")]
    [DisplayName("Crystallised Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrstllsdUnitsNb")]
    #endif
    [IsoXmlTag("CrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? CrystallisedUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CrystallisedUnitsNumber { get; init; } 
    #else
    public System.UInt64? CrystallisedUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units uncrystallised.
    /// </summary>
    [IsoId("_iUO40E3gEeidB49bWZiS0g")]
    [DisplayName("Uncrystallised Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UcrstllsdUnitsNb")]
    #endif
    [IsoXmlTag("UcrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? UncrystallisedUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? UncrystallisedUnitsNumber { get; init; } 
    #else
    public System.UInt64? UncrystallisedUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the crystallisation.
    /// </summary>
    [IsoId("_tmFnkE3gEeidB49bWZiS0g")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
