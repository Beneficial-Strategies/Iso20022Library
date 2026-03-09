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
[IsoId("_eh3qwA25EeWmAKKPnqYEVQ")]
[DisplayName("Master Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MasterAgreement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MasterAgreement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MasterAgreement1( AgreementType1Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of a master agreement.
    /// </summary>
    [IsoId("_aTEJ0GYUEeedgsIRl3TXQQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreementType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreementType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementType1Choice_ Type { get; init; } 
    #else
    public AgreementType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade.
    /// </summary>
    [IsoId("_hm13ow25EeWmAKKPnqYEVQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.ISORestrictedYear)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISORestrictedYear? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? Version { get; init; } 
    #else
    public System.UInt16? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specifying the other type of the master agreement.
    /// </summary>
    [IsoId("_ev_BEGYUEeedgsIRl3TXQQ")]
    [DisplayName("Other Master Agreement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrMstrAgrmtDtls")]
    #endif
    [IsoXmlTag("OthrMstrAgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? OtherMasterAgreementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherMasterAgreementDetails { get; init; } 
    #else
    public System.String? OtherMasterAgreementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
