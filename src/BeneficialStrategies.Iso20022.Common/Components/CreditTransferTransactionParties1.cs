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
/// Specifies all the parties involved in a cover payment transaction.
/// </summary>
[IsoId("_H1gUQDMmEeit26XNYhRFqg")]
[DisplayName("Credit Transfer Transaction Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransferTransactionParties1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    [IsoId("_MYGuATMsEeit26XNYhRFqg")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Debtor { get; init; } 
    #else
    public System.String? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_mHMX0TMrEeit26XNYhRFqg")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorAgent { get; init; } 
    #else
    public System.String? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_oEMQATMrEeit26XNYhRFqg")]
    [DisplayName("Intermediary Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyAgt1")]
    #endif
    [IsoXmlTag("IntrmyAgt1")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntermediaryAgent1 { get; init; } 
    #else
    public System.String? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_pvXYYTMrEeit26XNYhRFqg")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorAgent { get; init; } 
    #else
    public System.String? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    [IsoId("_EFU_gTMsEeit26XNYhRFqg")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Creditor { get; init; } 
    #else
    public System.String? Creditor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
