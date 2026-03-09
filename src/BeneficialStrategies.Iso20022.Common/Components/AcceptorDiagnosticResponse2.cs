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
/// Diagnostic response from the acquirer.
/// </summary>
[IsoId("_ryRAURz1EeK5OKMB21JFBg")]
[DisplayName("Acceptor Diagnostic Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorDiagnosticResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorDiagnosticResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorDiagnosticResponse2( CardPaymentEnvironment17 reqEnvironment )
    {
        Environment = reqEnvironment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_r-UfURz1EeK5OKMB21JFBg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment17 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment17 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment17 Environment { get; init; } 
    #else
    public CardPaymentEnvironment17 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_r-UfVRz1EeK5OKMB21JFBg")]
    [DisplayName("TMS Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSTrggr")]
    #endif
    [IsoXmlTag("TMSTrggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSTrigger1? TMSTrigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSTrigger1? TMSTrigger { get; init; } 
    #else
    public TMSTrigger1? TMSTrigger { get; set; } 
    #endif
    
    
    #nullable disable
    
}
