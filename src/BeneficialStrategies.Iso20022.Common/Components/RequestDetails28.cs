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
/// Details of the financial instrument removal request.
/// </summary>
[IsoId("_3bfJsStFEeySlt9bF77XfA")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails28 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails28( RemovalTypeAndReason1 reqRemoval )
    {
        Removal = reqRemoval;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the  removal processing change requested.
    /// </summary>
    [IsoId("_3zn84ytFEeySlt9bF77XfA")]
    [DisplayName("Removal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rmvl")]
    #endif
    [IsoXmlTag("Rmvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RemovalTypeAndReason1 Removal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RemovalTypeAndReason1 Removal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemovalTypeAndReason1 Removal { get; init; } 
    #else
    public RemovalTypeAndReason1 Removal { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the financial instruments to be removed  (identification or attributes). 
    /// </summary>
    [IsoId("_3zn85StFEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument And Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAndAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAndAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemovalProcessing2Choice_? FinancialInstrumentAndAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemovalProcessing2Choice_? FinancialInstrumentAndAttributes { get; init; } 
    #else
    public RemovalProcessing2Choice_? FinancialInstrumentAndAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the collateral parties of a contract.
    /// </summary>
    [IsoId("_3zn85ytFEeySlt9bF77XfA")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralParties4? Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties4? Counterparty { get; init; } 
    #else
    public CollateralParties4? Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_3zn86StFEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_UBHi0ytFEeySlt9bF77XfA")]
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
    
    /// <summary>
    /// References of the transaction for which the financial instrument removal request is required.
    /// </summary>
    [IsoId("_3zn86ytFEeySlt9bF77XfA")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reference21? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reference21? Reference { get; init; } 
    #else
    public Reference21? Reference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
