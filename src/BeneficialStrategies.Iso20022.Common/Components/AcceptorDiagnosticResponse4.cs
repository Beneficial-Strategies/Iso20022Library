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
[IsoId("_p4UxYWpBEeS4VPLpYyQgxQ")]
[DisplayName("Acceptor Diagnostic Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorDiagnosticResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorDiagnosticResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorDiagnosticResponse4( CardPaymentEnvironment43 reqEnvironment )
    {
        Environment = reqEnvironment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_qFS2YWpBEeS4VPLpYyQgxQ")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment43 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment43 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment43 Environment { get; init; } 
    #else
    public CardPaymentEnvironment43 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_qFS2Y2pBEeS4VPLpYyQgxQ")]
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
