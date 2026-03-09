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
/// Information about the creditor.
/// </summary>
[IsoId("_Urs4Itp-Ed-ak6NoX_4Aeg_1405520878")]
[DisplayName("Creditor")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Creditor2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Creditor2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Creditor2( AccountIdentificationAndName3 reqAccountIdentification,FinancialInstitutionIdentification3Choice_ reqFinalAgent )
    {
        AccountIdentification = reqAccountIdentification;
        FinalAgent = reqFinalAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_Urs4I9p-Ed-ak6NoX_4Aeg_1405520880")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? Creditor { get; init; } 
    #else
    public PartyIdentification2Choice_? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Urs4JNp-Ed-ak6NoX_4Aeg_1405520930")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentificationAndName3 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentificationAndName3 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName3 AccountIdentification { get; init; } 
    #else
    public AccountIdentificationAndName3 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is the ultimate beneficiary of the credit transfer. The final party is mentioned when different from the creditor, whose account will be credited by the final agent.
    /// </summary>
    [IsoId("_Urs4Jdp-Ed-ak6NoX_4Aeg_1405520895")]
    [DisplayName("Final Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlAgt")]
    #endif
    [IsoXmlTag("FnlAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification3Choice_ FinalAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification3Choice_ FinalAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification3Choice_ FinalAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification3Choice_ FinalAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
