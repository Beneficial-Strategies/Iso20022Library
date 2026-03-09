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
/// Services allowed for the customer&apos;s profile.
/// </summary>
[IsoId("_IAYH0Yq0EeSIDtZ76p6McQ")]
[DisplayName("ATM Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMService7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMService7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMService7( ATMServiceType4Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_INCq1Yq0EeSIDtZ76p6McQ")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMServiceType4Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMServiceType4Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType4Code ServiceType { get; init; } 
    #else
    public ATMServiceType4Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Limits of amounts.
    /// </summary>
    [IsoId("_nMR4QIq2EeSIDtZ76p6McQ")]
    [DisplayName("Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lmts")]
    #endif
    [IsoXmlTag("Lmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts3? Limits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts3? Limits { get; init; } 
    #else
    public ATMTransactionAmounts3? Limits { get; set; } 
    #endif
    
    /// <summary>
    /// Preferred withdrawal transaction chosen by the customer.
    /// </summary>
    [IsoId("_vyGCEIq3EeSIDtZ76p6McQ")]
    [DisplayName("Preferred Withdrawal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrefrdWdrwl")]
    #endif
    [IsoXmlTag("PrefrdWdrwl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransaction8? PreferredWithdrawal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction8? PreferredWithdrawal { get; init; } 
    #else
    public ATMTransaction8? PreferredWithdrawal { get; set; } 
    #endif
    
    
    #nullable disable
    
}
