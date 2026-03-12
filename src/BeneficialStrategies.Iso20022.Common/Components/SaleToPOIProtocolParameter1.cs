// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a sale system.
/// </summary>
[IsoId("_neYOcNqdEeearpaEPXv9UA")]
[DisplayName("Sale To POI Protocol Parameter")]
public partial record SaleToPOIProtocolParameter1
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_EImXMNqeEeearpaEPXv9UA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_L16oMNqeEeearpaEPXv9UA")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public Organisation26? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Version of the parameters.
    /// </summary>
    [IsoId("_TOfYQNqeEeearpaEPXv9UA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    [IsoId("_aPBbwNqeEeearpaEPXv9UA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    [IsoId("_hvDesNqeEeearpaEPXv9UA")]
    [DisplayName("Merchant POI Identification")]
    [IsoXmlTag("MrchntPOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MerchantPOIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    [IsoId("_rjt2sNqeEeearpaEPXv9UA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; } 
    
    
    #nullable disable
    
}
