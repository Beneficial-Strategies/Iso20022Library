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
/// Environment of the withdrawal transaction.
/// </summary>
[IsoId("_2LQFQa16EeWMg5rOByfExw")]
[DisplayName("ATM Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEnvironment12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMEnvironment12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMEnvironment12( AutomatedTellerMachine2 reqATM,ATMCustomer5 reqCustomer )
    {
        ATM = reqATM;
        Customer = reqCustomer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer of the transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_2XLBYa16EeWMg5rOByfExw")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer7? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer7? Acquirer { get; init; } 
    #else
    public Acquirer7? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Institution in charge of managing the ATM.
    /// </summary>
    [IsoId("_2XLBY616EeWMg5rOByfExw")]
    [DisplayName("ATM Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMMgr")]
    #endif
    [IsoXmlTag("ATMMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer8? ATMManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer8? ATMManager { get; init; } 
    #else
    public Acquirer8? ATMManager { get; set; } 
    #endif
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_2XLBZa16EeWMg5rOByfExw")]
    [DisplayName("Hosting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstgNtty")]
    #endif
    [IsoXmlTag("HstgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalHosting1? HostingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalHosting1? HostingEntity { get; init; } 
    #else
    public TerminalHosting1? HostingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_2XLBZ616EeWMg5rOByfExw")]
    [DisplayName("ATM")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATM")]
    #endif
    [IsoXmlTag("ATM")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AutomatedTellerMachine2 ATM { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AutomatedTellerMachine2 ATM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomatedTellerMachine2 ATM { get; init; } 
    #else
    public AutomatedTellerMachine2 ATM { get; set; } 
    #endif
    
    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_2XLBaa16EeWMg5rOByfExw")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCustomer5 Customer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCustomer5 Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomer5 Customer { get; init; } 
    #else
    public ATMCustomer5 Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of the sensitive card data.
    /// </summary>
    [IsoId("_2XLBa616EeWMg5rOByfExw")]
    [DisplayName("Protected Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCardData")]
    #endif
    [IsoXmlTag("PrtctdCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedCardData { get; init; } 
    #else
    public ContentInformationType10? ProtectedCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_2XLBba16EeWMg5rOByfExw")]
    [DisplayName("Plain Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlainCardData")]
    #endif
    [IsoXmlTag("PlainCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData19? PlainCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData19? PlainCardData { get; init; } 
    #else
    public PlainCardData19? PlainCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
