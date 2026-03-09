// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Possible types of Loyalty processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-jd2ENt3EeiXqq0XHEoNUA")]
[Description(@"Possible types of Loyalty processing.")]
[Derivations(typeof(LoyaltyHandling1Code))]
public enum LoyaltyHandlingCode
{
    /// <summary>
    /// No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.
    /// Encoded/decoded by serializers as &quot;DENY&quot;.
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_CyxIENt4EeiXqq0XHEoNUA")]
    [Description(@"No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.")]
    Forbidden,
    
    /// <summary>
    /// The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.
    /// Encoded/decoded by serializers as &quot;PRCS&quot;.
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_FzfHENt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.")]
    Processed,
    
    /// <summary>
    /// The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). 
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_I950oNt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). ")]
    Allowed,
    
    /// <summary>
    /// The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_MThFkNt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.")]
    Proposed,
    
    /// <summary>
    /// The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_PYggkNt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.")]
    Required,
    
}
