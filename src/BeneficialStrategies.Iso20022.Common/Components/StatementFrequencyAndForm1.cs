// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a frequency, format and delivery address for statements.
/// </summary>
[IsoId("_Xr9A8A1gEeKGXqvMN6jpiw")]
[DisplayName("Statement Frequency And Form")]
public partial record StatementFrequencyAndForm1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the frequency for sending statements.
    /// </summary>
    [IsoId("_ip_b0A1gEeKGXqvMN6jpiw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency7Code Frequency { get; init; } 
    
    /// <summary>
    /// Specifies the communication method for statements.
    /// </summary>
    [IsoId("_v6zxoA1gEeKGXqvMN6jpiw")]
    [DisplayName("Communication Method")]
    [IsoXmlTag("ComMtd")]
    public required CommunicationMethod2Choice_ CommunicationMethod { get; init; } 
    
    /// <summary>
    /// Specifies the delivery address for statements.
    /// </summary>
    [IsoId("_5MpwcA1gEeKGXqvMN6jpiw")]
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text DeliveryAddress { get; init; } 
    
    /// <summary>
    /// Specifies the format for statements.
    /// </summary>
    [IsoId("__ID-8A1gEeKGXqvMN6jpiw")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required CommunicationFormat1Choice_ Format { get; init; } 
    
    
    #nullable disable
    
}
