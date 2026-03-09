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
/// Choice of format for the trading capacity.
/// </summary>
[IsoId("_XXfF4Ss-EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParties8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParties8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParties8( PartyIdentificationAndAccount202 reqPartyA,PartyIdentificationAndAccount203 reqPartyB )
    {
        PartyA = reqPartyA;
        PartyB = reqPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Instructing party sending the collateral instruction.
    /// </summary>
    [IsoId("_XvU-ISs-EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyA")]
    #endif
    [IsoXmlTag("PtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount202 PartyA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount202 PartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount202 PartyA { get; init; } 
    #else
    public PartyIdentificationAndAccount202 PartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_XvU-Iys-EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntPtyA")]
    #endif
    [IsoXmlTag("ClntPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount193? ClientPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount193? ClientPartyA { get; init; } 
    #else
    public PartyIdentificationAndAccount193? ClientPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparty of party A. 
    /// </summary>
    [IsoId("_XvU-JSs-EeySlt9bF77XfA")]
    [DisplayName("Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyB")]
    #endif
    [IsoXmlTag("PtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount203 PartyB { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount203 PartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount203 PartyB { get; init; } 
    #else
    public PartyIdentificationAndAccount203 PartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_XvU-Jys-EeySlt9bF77XfA")]
    [DisplayName("Client Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntPtyB")]
    #endif
    [IsoXmlTag("ClntPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount193? ClientPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount193? ClientPartyB { get; init; } 
    #else
    public PartyIdentificationAndAccount193? ClientPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_XvU-KSs-EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? TripartyAgent { get; init; } 
    #else
    public PartyIdentification136? TripartyAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
