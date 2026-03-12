// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[IsoId("_oGnfIQufEeqw5uEXxQ9H4g")]
[DisplayName("Merchant Configuration Parameters")]
public partial record MerchantConfigurationParameters5
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_oRc2IQufEeqw5uEXxQ9H4g")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [IsoId("_oRc2IwufEeqw5uEXxQ9H4g")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [IsoId("_oRc2JQufEeqw5uEXxQ9H4g")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_oRc2JwufEeqw5uEXxQ9H4g")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    
    /// <summary>
    /// Local proxy configuration.
    /// </summary>
    [IsoId("_oRc2KQufEeqw5uEXxQ9H4g")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public NetworkParameters8? Proxy { get; init; } 
    
    /// <summary>
    /// Other merchant parameters.
    /// </summary>
    [IsoId("_oRc2KwufEeqw5uEXxQ9H4g")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; } 
    
    
    #nullable disable
    
}
