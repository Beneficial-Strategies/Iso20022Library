// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction.
/// </summary>
[IsoId("_Yqs_gHrvEeSz_of_1TY14A")]
[DisplayName("Card Acceptor Terminal")]
public partial record CardAcceptorTerminal1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal. 
    /// It correspond to the ISO 8583 field number 41.
    /// </summary>
    [IsoId("_DxCzkHrwEeSz_of_1TY14A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; } 
    
    /// <summary>
    /// Location of the terminal.
    /// </summary>
    [IsoId("_ICRYMHrwEeSz_of_1TY14A")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress18? Location { get; init; } 
    
    /// <summary>
    /// Capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_NqmSoHrwEeSz_of_1TY14A")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public required PointOfInteractionCapabilities4 Capabilities { get; init; } 
    
    
    #nullable disable
    
}
