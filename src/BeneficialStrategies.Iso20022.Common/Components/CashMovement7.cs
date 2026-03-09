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
/// Movements of cash.
/// </summary>
[IsoId("_qliBoRIwEeydmIVkS03esw")]
[DisplayName("Cash Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashMovement7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashMovement7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashMovement7( CreditDebit3Code reqCashMovement,ActiveCurrencyAndAmount reqCashAmount,System.String reqCollateralMovement )
    {
        CashMovement = reqCashMovement;
        CashAmount = reqCashAmount;
        CollateralMovement = reqCollateralMovement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the cash amount is to be delivered or received.
    /// </summary>
    [IsoId("_q7lKIRIwEeydmIVkS03esw")]
    [DisplayName("Cash Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmnt")]
    #endif
    [IsoXmlTag("CshMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebit3Code CashMovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebit3Code CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code CashMovement { get; init; } 
    #else
    public CreditDebit3Code CashMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the cash movement.
    /// </summary>
    [IsoId("_q7lKIxIwEeydmIVkS03esw")]
    [DisplayName("Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmt")]
    #endif
    [IsoXmlTag("CshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_q7lKJRIwEeydmIVkS03esw")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement status
    /// </summary>
    [IsoId("_q7lKJxIwEeydmIVkS03esw")]
    [DisplayName("Movement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntSts")]
    #endif
    [IsoXmlTag("MvmntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryStatusAndReason6? MovementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryStatusAndReason6? MovementStatus { get; init; } 
    #else
    public ProprietaryStatusAndReason6? MovementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    [IsoId("_q7lKKRIwEeydmIVkS03esw")]
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
    /// Indicates whether the proposed cash movements can be accepted.
    /// </summary>
    [IsoId("_q7lKKxIwEeydmIVkS03esw")]
    [DisplayName("Cash Movement Approved")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntApprvd")]
    #endif
    [IsoXmlTag("CshMvmntApprvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CashMovementApproved { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashMovementApproved { get; init; } 
    #else
    public System.String? CashMovementApproved { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the position is fixed (post settlement).
    /// </summary>
    [IsoId("_q7lKLRIwEeydmIVkS03esw")]
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
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    [IsoId("_q7lKLxIwEeydmIVkS03esw")]
    [DisplayName("Client Cash Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCshMvmntId")]
    #endif
    [IsoXmlTag("ClntCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientCashMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientCashMovementIdentification { get; init; } 
    #else
    public System.String? ClientCashMovementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the triparty-agent/service-provider to the cash movement.
    /// </summary>
    [IsoId("_q7lKMRIwEeydmIVkS03esw")]
    [DisplayName("Triparty Agent Service Provider Cash Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrCshMvmntId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrCshMvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TripartyAgentServiceProviderCashMovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TripartyAgentServiceProviderCashMovementIdentification { get; init; } 
    #else
    public System.String? TripartyAgentServiceProviderCashMovementIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
