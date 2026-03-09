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
/// Identifies the chain of collateral parties of counterparty of Party A.
/// </summary>
[IsoId("_SBomESs_EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParties11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParties11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParties11( PartyIdentification232 reqPartyB )
    {
        PartyB = reqPartyB;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Counterparty of party A. 
    /// </summary>
    [IsoId("_SZLjYSs_EeySlt9bF77XfA")]
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
    [IsoId("_SZLjYys_EeySlt9bF77XfA")]
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
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_SZLjZSs_EeySlt9bF77XfA")]
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
    
    /// <summary>
    /// Account where the collateral is held during the lifecycle  of the transaction.
    /// </summary>
    [IsoId("_SZLjZys_EeySlt9bF77XfA")]
    [DisplayName("Collateral Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcct")]
    #endif
    [IsoXmlTag("CollAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? CollateralAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? CollateralAccount { get; init; } 
    #else
    public SecuritiesAccount19? CollateralAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_L4oOMytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
