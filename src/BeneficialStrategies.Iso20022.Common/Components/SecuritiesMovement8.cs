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
[IsoId("_qJOe4StEEeySlt9bF77XfA")]
[DisplayName("Securities Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesMovement8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesMovement8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesMovement8( ReceiveDelivery1Code reqSecuritiesMovementType,SecurityIdentification19 reqFinancialInstrumentIdentification,Quantity51Choice_ reqSecuritiesQuantity,System.String reqCollateralMovement )
    {
        SecuritiesMovementType = reqSecuritiesMovementType;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        SecuritiesQuantity = reqSecuritiesQuantity;
        CollateralMovement = reqCollateralMovement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument are to be delivered or received 
    /// </summary>
    [IsoId("_qhOIIStEEeySlt9bF77XfA")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_qhOIIytEEeySlt9bF77XfA")]
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
    [IsoId("_qhOIJStEEeySlt9bF77XfA")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity51Choice_ SecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity51Choice_ SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity51Choice_ SecuritiesQuantity { get; init; } 
    #else
    public Quantity51Choice_ SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Securities movement status.
    /// </summary>
    [IsoId("_qhOIJytEEeySlt9bF77XfA")]
    [DisplayName("Movement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntSts")]
    #endif
    [IsoXmlTag("MvmntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesMovementStatus1Choice_? MovementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesMovementStatus1Choice_? MovementStatus { get; init; } 
    #else
    public SecuritiesMovementStatus1Choice_? MovementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral.
    /// </summary>
    [IsoId("_qhOIKStEEeySlt9bF77XfA")]
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
    /// Indicates whether the proposed securities movements can be accepted.
    /// </summary>
    [IsoId("_qhOIKytEEeySlt9bF77XfA")]
    [DisplayName("Securities Movements Approved")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntsApprvd")]
    #endif
    [IsoXmlTag("SctiesMvmntsApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecuritiesMovementsApproved { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesMovementsApproved { get; init; } 
    #else
    public System.String? SecuritiesMovementsApproved { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the position is fixed (post settlement).
    /// </summary>
    [IsoId("_qhOILStEEeySlt9bF77XfA")]
    [DisplayName("Position Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosTp")]
    #endif
    [IsoXmlTag("PosTp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PositionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PositionType { get; init; } 
    #else
    public System.String? PositionType { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_qhOILytEEeySlt9bF77XfA")]
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
    [IsoId("_aAHGQytEEeySlt9bF77XfA")]
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
    /// Reference assigned by the party A to the financial instrument movement.
    /// </summary>
    [IsoId("_qhOIMStEEeySlt9bF77XfA")]
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
    /// Reference assigned by the triparty-agent/service-provider to the financial instrument movement.
    /// </summary>
    [IsoId("_qhOIMytEEeySlt9bF77XfA")]
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
    
    /// <summary>
    /// Value of the collateral position.
    /// </summary>
    [IsoId("_qhOINStEEeySlt9bF77XfA")]
    [DisplayName("Margined Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgndVal")]
    #endif
    [IsoXmlTag("MrgndVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? MarginedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? MarginedValue { get; init; } 
    #else
    public AmountAndDirection44? MarginedValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
