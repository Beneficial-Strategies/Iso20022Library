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
/// Information related to a master agreement.
/// </summary>
[IsoId("_JIKzgS4yEeuxhbw_aW6haw")]
[DisplayName("Master Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MasterAgreement7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MasterAgreement7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MasterAgreement7( AgreementType2Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to any master agreement, if existent (such as ISDA Master Agreement; Master Power Purchase and Sale Agreement; International ForEx Master Agreement; European Master Agreement or any local Master Agreements).
    /// </summary>
    [IsoId("_Jf0egS4yEeuxhbw_aW6haw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreementType2Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreementType2Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementType2Choice_ Type { get; init; } 
    #else
    public AgreementType2Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade, if applicable (such as 1992, 2002, etc).
    /// </summary>
    [IsoId("_Jf0egy4yEeuxhbw_aW6haw")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specifying the other type of the master agreement.
    /// </summary>
    [IsoId("_J6ADoS4zEeuxhbw_aW6haw")]
    [DisplayName("Other Master Agreement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrMstrAgrmtDtls")]
    #endif
    [IsoXmlTag("OthrMstrAgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? OtherMasterAgreementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherMasterAgreementDetails { get; init; } 
    #else
    public System.String? OtherMasterAgreementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
