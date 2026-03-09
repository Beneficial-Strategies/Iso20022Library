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
[IsoId("_1ahuN5a-EeuPNt5jNVou1A")]
[DisplayName("Cash Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashMovement5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashMovement5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashMovement5( CollateralEntryType1Code reqCashMovement,ActiveCurrencyAndAmount reqCashAmount,System.String reqCollateralMovement )
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
    [IsoId("_1ahuO5a-EeuPNt5jNVou1A")]
    [DisplayName("Cash Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmnt")]
    #endif
    [IsoXmlTag("CshMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralEntryType1Code CashMovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralEntryType1Code CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralEntryType1Code CashMovement { get; init; } 
    #else
    public CollateralEntryType1Code CashMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the cash movement
    /// </summary>
    [IsoId("_1ahuPZa-EeuPNt5jNVou1A")]
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
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    [IsoId("_1ahuPJa-EeuPNt5jNVou1A")]
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
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    [IsoId("_1ahuOpa-EeuPNt5jNVou1A")]
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
    /// Reference assigned by the triparty agent to the cash movement.
    /// </summary>
    [IsoId("_1ahuOZa-EeuPNt5jNVou1A")]
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
