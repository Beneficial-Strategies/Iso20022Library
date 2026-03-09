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
/// Specifies the beneficiary&apos;s account information for the settlement of a purchase of goods or services.
/// </summary>
[IsoId("_QIrY5tp-Ed-ak6NoX_4Aeg_739233613")]
[DisplayName("Settlement Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTerms2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementTerms2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementTerms2( CashAccount7 reqCreditorAccount )
    {
        CreditorAccount = reqCreditorAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, and posts the transaction into the account.
    /// </summary>
    [IsoId("_QIrY59p-Ed-ak6NoX_4Aeg_739233984")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification4Choice_? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification4Choice_? CreditorAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification4Choice_? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be credited as a result of an instruction.
    /// </summary>
    [IsoId("_QIrY6Np-Ed-ak6NoX_4Aeg_739233923")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount7 CreditorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount7 CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7 CreditorAccount { get; init; } 
    #else
    public CashAccount7 CreditorAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
