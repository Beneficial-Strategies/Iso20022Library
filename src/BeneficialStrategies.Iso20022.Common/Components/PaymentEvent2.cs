// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains elements identifying an event belonging to the transaction.
/// </summary>
[IsoId("_TsN2cKJoEeaLbOzg6lYrCA")]
[DisplayName("Payment Event")]
public partial record PaymentEvent2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_hqnrAqJoEeaLbOzg6lYrCA")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier From { get; init; } 
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Usage:
    /// the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_hqoSEKJoEeaLbOzg6lYrCA")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier To { get; init; } 
    
    /// <summary>
    /// Indicates whether a payment has been received or not. 
    /// </summary>
    [IsoId("_wvnewKJpEeaLbOzg6lYrCA")]
    [DisplayName("Received")]
    [IsoXmlTag("Rcvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Received { get; init; } 
    
    
    #nullable disable
    
}
