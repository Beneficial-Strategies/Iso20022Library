// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary of electronic message details.
/// </summary>
[IsoId("_kmUEIAepEeaA3oFk37UuZA")]
[DisplayName("Electronic Message Details")]
public partial record ElectronicMessageDetails1
{
    #nullable enable
    
    /// <summary>
    /// Information about separate electronic system information message.
    /// </summary>
    [IsoId("_cxD_sBa-Eea0P4Zamlsl-Q")]
    [DisplayName("Electronic System Information Message Identifier")]
    [IsoXmlTag("ElctrncSysInfMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ElectronicSystemInformationMessageIdentifier { get; init; } 
    
    /// <summary>
    /// Information about packet of electronic system messages.
    /// </summary>
    [IsoId("_w6t1kBa-Eea0P4Zamlsl-Q")]
    [DisplayName("Electronic System Information Message Packet Identifier")]
    [IsoXmlTag("ElctrncSysInfMsgPacketIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ElectronicSystemInformationMessagePacketIdentifier { get; init; } 
    
    
    #nullable disable
    
}
