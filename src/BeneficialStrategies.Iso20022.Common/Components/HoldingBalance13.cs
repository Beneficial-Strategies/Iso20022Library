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
[IsoId("_vh_0oTUEEe2tRf29bleifQ")]
[DisplayName("Holding Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HoldingBalance13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HoldingBalance13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HoldingBalance13( SignedQuantityFormat14 reqBalance,SecuritiesEntryType3Code reqBalanceType )
    {
        Balance = reqBalance;
        BalanceType = reqBalanceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    [IsoId("_v4DkMzUEEe2tRf29bleifQ")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignedQuantityFormat14 Balance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignedQuantityFormat14 Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat14 Balance { get; init; } 
    #else
    public SignedQuantityFormat14 Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_v4DkNTUEEe2tRf29bleifQ")]
    [DisplayName("Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTp")]
    #endif
    [IsoXmlTag("BalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesEntryType3Code BalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesEntryType3Code BalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesEntryType3Code BalanceType { get; init; } 
    #else
    public SecuritiesEntryType3Code BalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
