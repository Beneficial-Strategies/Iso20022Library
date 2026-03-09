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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_xey5kzT5Ee2j2eQlcOSMKg")]
[DisplayName("Holding Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HoldingBalance12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HoldingBalance12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HoldingBalance12( SignedQuantityFormat15 reqBalance )
    {
        Balance = reqBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_x0jHEzT5Ee2j2eQlcOSMKg")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignedQuantityFormat15 Balance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignedQuantityFormat15 Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat15 Balance { get; init; } 
    #else
    public SignedQuantityFormat15 Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_x0jHFTT5Ee2j2eQlcOSMKg")]
    [DisplayName("Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTp")]
    #endif
    [IsoXmlTag("BalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesEntryType2Code? BalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesEntryType2Code? BalanceType { get; init; } 
    #else
    public SecuritiesEntryType2Code? BalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_x0jHFzT5Ee2j2eQlcOSMKg")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    
    #nullable disable
    
}
