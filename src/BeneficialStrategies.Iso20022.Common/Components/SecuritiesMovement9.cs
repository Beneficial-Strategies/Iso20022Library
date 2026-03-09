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
/// Movements of securities.
/// </summary>
[IsoId("_TSUjIStFEeySlt9bF77XfA")]
[DisplayName("Securities Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesMovement9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesMovement9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesMovement9( CollateralEntryType1Code reqSecuritiesMovementType,SecurityIdentification19 reqFinancialInstrumentIdentification,FinancialInstrumentQuantity33Choice_ reqQuantity,System.String reqCollateralMovement )
    {
        SecuritiesMovementType = reqSecuritiesMovementType;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Quantity = reqQuantity;
        CollateralMovement = reqCollateralMovement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is to be delivered or received.
    /// </summary>
    [IsoId("_Tq6pUStFEeySlt9bF77XfA")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralEntryType1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralEntryType1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralEntryType1Code SecuritiesMovementType { get; init; } 
    #else
    public CollateralEntryType1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Tq6pUytFEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_Tq6pVStFEeySlt9bF77XfA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_Tq6pVytFEeySlt9bF77XfA")]
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
    [IsoId("_-zu_EytEEeySlt9bF77XfA")]
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
    /// Indicates whether the financial instrument is delivered/received as collateral or as a loan.
    /// </summary>
    [IsoId("_Tq6pWStFEeySlt9bF77XfA")]
    [DisplayName("Collateral Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMvmnt")]
    #endif
    [IsoXmlTag("CollMvmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CollateralMovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralMovement { get; init; } 
    #else
    public System.String CollateralMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the party A to the financial instrument movement.
    /// </summary>
    [IsoId("_Tq6pWytFEeySlt9bF77XfA")]
    [DisplayName("Client Securities Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntSctiesMvmntId")]
    #endif
    [IsoXmlTag("ClntSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientSecuritiesMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientSecuritiesMovementIdentification { get; init; } 
    #else
    public System.String? ClientSecuritiesMovementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the triparty agent to the financial instrument movement.
    /// </summary>
    [IsoId("_Tq6pXStFEeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Securities Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrSctiesMvmntId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrSctiesMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderSecuritiesMovementIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
