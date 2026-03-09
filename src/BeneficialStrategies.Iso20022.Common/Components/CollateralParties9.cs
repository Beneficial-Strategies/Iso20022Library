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
/// Identifies the chain of collateral parties on the instruction side.
/// </summary>
[IsoId("_YHwsTSs-EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParties9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Instructing party sending the collateral instruction.
    /// </summary>
    [IsoId("_YgDQdys-EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyA")]
    #endif
    [IsoXmlTag("PtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount202? PartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount202? PartyA { get; init; } 
    #else
    public PartyIdentificationAndAccount202? PartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_YgDQeSs-EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntPtyA")]
    #endif
    [IsoXmlTag("ClntPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount202? ClientPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount202? ClientPartyA { get; init; } 
    #else
    public PartyIdentificationAndAccount202? ClientPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_YgDQeys-EeySlt9bF77XfA")]
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
