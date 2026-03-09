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
[IsoId("_-wXU0YqOEeSRT5rEzcAHEw")]
[DisplayName("ATM Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEnvironment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMEnvironment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMEnvironment3( AutomatedTellerMachine1 reqATM,ATMCustomer3 reqCustomer )
    {
        ATM = reqATM;
        Customer = reqCustomer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_-8u84YqOEeSRT5rEzcAHEw")]
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
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_-8u844qOEeSRT5rEzcAHEw")]
    [DisplayName("ATM Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMMgrId")]
    #endif
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMManagerIdentification { get; init; } 
    #else
    public System.String? ATMManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_-8u85YqOEeSRT5rEzcAHEw")]
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
    [IsoId("_-8u854qOEeSRT5rEzcAHEw")]
    [DisplayName("ATM")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATM")]
    #endif
    [IsoXmlTag("ATM")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AutomatedTellerMachine1 ATM { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AutomatedTellerMachine1 ATM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomatedTellerMachine1 ATM { get; init; } 
    #else
    public AutomatedTellerMachine1 ATM { get; set; } 
    #endif
    
    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_-8u86YqOEeSRT5rEzcAHEw")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCustomer3 Customer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCustomer3 Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomer3 Customer { get; init; } 
    #else
    public ATMCustomer3 Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_-8u864qOEeSRT5rEzcAHEw")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard17? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard17? Card { get; init; } 
    #else
    public PaymentCard17? Card { get; set; } 
    #endif
    
    
    #nullable disable
    
}
