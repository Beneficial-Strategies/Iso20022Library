// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Host Communication Parameter7.
/// </summary>
[IsoId("_PufjgZ9xEe-nbM0aSPcoiQ")]
[DisplayName("Host Communication Parameter7")]
public partial record HostCommunicationParameter7
{
    #nullable enable

    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters7? Address { get; init; } 

    /// <summary>
    /// Encoding Mode.
    /// </summary>
    [DisplayName("Encoding Mode")]
    [IsoXmlTag("NcodgMd")]
    public CAPEEncodingMode1Code? EncodingMode { get; init; } 

    /// <summary>
    /// Exchange Mode.
    /// </summary>
    [DisplayName("Exchange Mode")]
    [IsoXmlTag("XchgMd")]
    public CAPEExchangeMode1Code? ExchangeMode { get; init; } 

    /// <summary>
    /// Host Identification.
    /// </summary>
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; } 

    /// <summary>
    /// Key.
    /// </summary>
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<KEKIdentifier5> Key { get; init; } = [];

    /// <summary>
    /// Network Service Provider.
    /// </summary>
    [DisplayName("Network Service Provider")]
    [IsoXmlTag("NtwkSvcPrvdr")]
    public NetworkParameters7? NetworkServiceProvider { get; init; } 

    /// <summary>
    /// Physical Interface.
    /// </summary>
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 

    
    #nullable disable
    
}
