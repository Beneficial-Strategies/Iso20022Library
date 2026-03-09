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
/// Specifies the detailed parameters a service to be billed.
/// </summary>
[IsoId("_6PgXwZqlEeGSON8vddiWzQ_-423301635")]
[DisplayName("Billing Service Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServiceParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServiceParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServiceParameters1( BillingServiceIdentification1 reqBankService )
    {
        BankService = reqBankService;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the details to fully identify the bank service.
    /// </summary>
    [IsoId("_6PgXwpqlEeGSON8vddiWzQ_-245182963")]
    [DisplayName("Bank Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkSvc")]
    #endif
    [IsoXmlTag("BkSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingServiceIdentification1 BankService { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingServiceIdentification1 BankService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceIdentification1 BankService { get; init; } 
    #else
    public BillingServiceIdentification1 BankService { get; set; } 
    #endif
    
    /// <summary>
    /// Count or number of items (volume) involved in the charge.
    /// </summary>
    [IsoId("_6PgXw5qlEeGSON8vddiWzQ_-537140701")]
    [DisplayName("Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vol")]
    #endif
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Volume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Volume { get; init; } 
    #else
    public System.UInt64? Volume { get; set; } 
    #endif
    
    
    #nullable disable
    
}
