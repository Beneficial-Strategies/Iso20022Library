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
/// Specifies settlement parties (delivering/receiving).
/// </summary>
[IsoId("_SiKYzNp-Ed-ak6NoX_4Aeg_-74170439")]
[DisplayName("Settlement Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementParties4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementParties4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementParties4( PartyIdentification35 reqDepository,PartyIdentificationAndAccount14 reqParty1 )
    {
        Depository = reqDepository;
        Party1 = reqParty1;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_SiKYzdp-Ed-ak6NoX_4Aeg_272147056")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35 Depository { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35 Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35 Depository { get; init; } 
    #else
    public PartyIdentification35 Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the Depository.
    /// </summary>
    [IsoId("_SiKYztp-Ed-ak6NoX_4Aeg_-1338015493")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty1")]
    #endif
    [IsoXmlTag("Pty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount14 Party1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount14 Party1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount14 Party1 { get; init; } 
    #else
    public PartyIdentificationAndAccount14 Party1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the Party1.
    /// </summary>
    [IsoId("_SiKYz9p-Ed-ak6NoX_4Aeg_-1252127887")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty2")]
    #endif
    [IsoXmlTag("Pty2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount14? Party2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount14? Party2 { get; init; } 
    #else
    public PartyIdentificationAndAccount14? Party2 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the Party2.
    /// </summary>
    [IsoId("_SiKY0Np-Ed-ak6NoX_4Aeg_-1010167039")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty3")]
    #endif
    [IsoXmlTag("Pty3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount14? Party3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount14? Party3 { get; init; } 
    #else
    public PartyIdentificationAndAccount14? Party3 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
