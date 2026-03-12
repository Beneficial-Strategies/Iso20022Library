// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Used to subscribe or unsubscribe for the receipt of a certain message.
/// </summary>
[IsoId("_Q78B09p-Ed-ak6NoX_4Aeg_-246540997")]
[DisplayName("Subscription Request")]
public partial record SubscriptionRequest
{
    #nullable enable
    
    /// <summary>
    /// Used to subscribe or unsubscribe for the receipt of a certain message.
    /// </summary>
    [IsoXmlTag("SbcptReq")]
    public required SubscriptionRequest1Code Value { get; init; } 
    
    
    #nullable disable
    
}
