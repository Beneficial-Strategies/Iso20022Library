// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Possible types of Loyalty processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UGjkENt4EeiXqq0XHEoNUA")]
[Description(@"Possible types of Loyalty processing.")]
[DerivedFrom(typeof(LoyaltyHandlingCode))]
public enum LoyaltyHandling1Code
{
    /// <summary>
    /// The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). 
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_WKvCUdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, but the POI has not to require or ask a loyalty card. The loyalty is involved by the payment card (e.g. an hybrid or linked card). ")]
    Allowed = LoyaltyHandlingCode.Allowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.
    /// Encoded/decoded by serializers as &quot;DENY&quot;.
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_WO5Jkdt4EeiXqq0XHEoNUA")]
    [Description(@"No loyalty card to read and loyalty transaction to process. 	Any attempt to enter a pure loyalty card is rejected.")]
    Forbidden = LoyaltyHandlingCode.Forbidden, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.
    /// Encoded/decoded by serializers as &quot;PRCS&quot;.
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_WS0nUdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty transaction is already processed, no loyalty card or loyalty transaction to process.")]
    Processed = LoyaltyHandlingCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_WW-Hgdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is accepted, and the POI has to ask a loyalty card. If the Customer does not enter a loyalty card, no loyalty transaction is realised.")]
    Proposed = LoyaltyHandlingCode.Proposed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_WbW4Qdt4EeiXqq0XHEoNUA")]
    [Description(@"The loyalty is required, and the POI refuses the processing 	of the message request if the cardholder does not enter a loyalty card.")]
    Required = LoyaltyHandlingCode.Required, // same ordinal as derivation source for type conversions
    
}
