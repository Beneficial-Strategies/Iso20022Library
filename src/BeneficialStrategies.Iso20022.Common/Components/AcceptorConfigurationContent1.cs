// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
[IsoId("_Ksg2xX1DEeCF8NjrBemJWQ_1156169068")]
[DisplayName("Acceptor Configuration Content")]
public partial record AcceptorConfigurationContent1
{
    #nullable enable
    
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_Ksg2xn1DEeCF8NjrBemJWQ_2005180344")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters1? AcquirerProtocolParameters { get; init; } 
    
    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_Ksg2x31DEeCF8NjrBemJWQ_1029963495")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? MerchantParameters { get; init; } 
    
    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_Ksg2yH1DEeCF8NjrBemJWQ_1720135233")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters1? ApplicationParameters { get; init; } 
    
    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    [IsoId("_Ksg2yX1DEeCF8NjrBemJWQ_-131390732")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter1? HostCommunicationParameters { get; init; } 
    
    
    #nullable disable
    
}
