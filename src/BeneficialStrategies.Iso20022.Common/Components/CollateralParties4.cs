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
/// Identifies the collateral counterparty(ies) of Party A with his eligibility set profile.
/// </summary>
[IsoId("_WfxEk_osEeiAfJEqh4xF_Q")]
[DisplayName("Collateral Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParties4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParties4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParties4( PartyIdentification232 reqPartyB )
    {
        PartyB = reqPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Counterparty of party A. 
    /// </summary>
    [IsoId("_WfxElPosEeiAfJEqh4xF_Q")]
    [DisplayName("Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyB")]
    #endif
    [IsoXmlTag("PtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification232 PartyB { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification232 PartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232 PartyB { get; init; } 
    #else
    public PartyIdentification232 PartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_WfxElfosEeiAfJEqh4xF_Q")]
    [DisplayName("Client Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntPtyB")]
    #endif
    [IsoXmlTag("ClntPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232? ClientPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232? ClientPartyB { get; init; } 
    #else
    public PartyIdentification232? ClientPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_2lmYkfosEeiAfJEqh4xF_Q")]
    [DisplayName("Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltySetPrfl")]
    #endif
    [IsoXmlTag("ElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? EligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? EligibilitySetProfile { get; init; } 
    #else
    public GenericIdentification37? EligibilitySetProfile { get; set; } 
    #endif
    
    
    #nullable disable
    
}
