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
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_ExNJ0Yp3EeS3NqNpgnMh2w")]
[DisplayName("ATM Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCustomer2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the withdrawal.
    /// </summary>
    [IsoId("_E9kx4Yp3EeS3NqNpgnMh2w")]
    [DisplayName("Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prfl")]
    #endif
    [IsoXmlTag("Prfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCustomerProfile2? Profile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomerProfile2? Profile { get; init; } 
    #else
    public ATMCustomerProfile2? Profile { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_E9kx54p3EeS3NqNpgnMh2w")]
    [DisplayName("Authentication Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnRslt")]
    #endif
    [IsoXmlTag("AuthntcnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    #else
    public TransactionVerificationResult5? AuthenticationResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
