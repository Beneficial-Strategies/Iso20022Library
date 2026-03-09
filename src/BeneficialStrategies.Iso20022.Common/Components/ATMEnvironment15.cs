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
/// Environment of the key download.
/// </summary>
[IsoId("_viPjIa45EeWRfYPBaeOY8w")]
[DisplayName("ATM Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEnvironment15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMEnvironment15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMEnvironment15( AutomatedTellerMachine6 reqATM )
    {
        ATM = reqATM;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_vtkpYa45EeWRfYPBaeOY8w")]
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
    [IsoId("_vtkpY645EeWRfYPBaeOY8w")]
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
    [IsoId("_vtkpZa45EeWRfYPBaeOY8w")]
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
    [IsoId("_vtkpZ645EeWRfYPBaeOY8w")]
    [DisplayName("ATM")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATM")]
    #endif
    [IsoXmlTag("ATM")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AutomatedTellerMachine6 ATM { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AutomatedTellerMachine6 ATM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomatedTellerMachine6 ATM { get; init; } 
    #else
    public AutomatedTellerMachine6 ATM { get; set; } 
    #endif
    
    
    #nullable disable
    
}
