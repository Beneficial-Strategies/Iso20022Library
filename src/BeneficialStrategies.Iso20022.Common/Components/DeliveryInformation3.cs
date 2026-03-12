// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivery information
/// </summary>
[IsoId("_B8QRk_cpEeiW-auGnDPZIw")]
[DisplayName("Delivery Information")]
public partial record DeliveryInformation3
{
    #nullable enable
    
    /// <summary>
    /// Contains the number identifying an individual delivery note. 
    /// </summary>
    [IsoId("_MeCOQPcpEeiW-auGnDPZIw")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DeliveryNoteNumber { get; init; } 
    
    /// <summary>
    /// Delivery address.
    /// </summary>
    [IsoId("_B8QRlfcpEeiW-auGnDPZIw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; } 
    
    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_B8QRlPcpEeiW-auGnDPZIw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; } 
    
    /// <summary>
    /// Special instructions. 
    /// </summary>
    [IsoId("_6IhaEfcpEeiW-auGnDPZIw")]
    [DisplayName("Instructions")]
    [IsoXmlTag("Instrs")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Instructions { get; init; } 
    
    /// <summary>
    /// Contains the package delivery date.
    /// </summary>
    [IsoId("_C8ejAvcqEeiW-auGnDPZIw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Contains the package delivery time.
    /// </summary>
    [IsoId("_C8ejA_cqEeiW-auGnDPZIw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    
    #nullable disable
    
}
