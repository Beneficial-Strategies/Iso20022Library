// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the business context of the transaction
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-CNYXC7Ee2bmOA3bkVsMg")]
[Description(@"Specifies the business context of the transaction")]
[DerivedFrom(typeof(BusinessAreaCode))]
public enum BusinessArea2Code
{
    /// <summary>
    /// The payment is initiated by an artificial intelligence based decision.
    /// Encoded/decoded by serializers as &quot;AIBD&quot;.
    /// </summary>
    [EnumMember(Value = "AIBD")]
    [IsoId("_qGBrwXC7Ee2bmOA3bkVsMg")]
    [Description(@"The payment is initiated by an artificial intelligence based decision.")]
    ArtificialIntelligenceBasedDecision = BusinessAreaCode.ArtificialIntelligenceBasedDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used to perform a plain payment.
    /// Encoded/decoded by serializers as &quot;PPAY&quot;.
    /// </summary>
    [EnumMember(Value = "PPAY")]
    [IsoId("_qGBrxXC7Ee2bmOA3bkVsMg")]
    [Description(@"The card is used to perform a plain payment.")]
    PlainPayment = BusinessAreaCode.PlainPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used in a Transit business case where the fare amount is known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;TKNF&quot;.
    /// </summary>
    [EnumMember(Value = "TKNF")]
    [IsoId("_qGBrx3C7Ee2bmOA3bkVsMg")]
    [Description(@"The card is used in a Transit business case where the fare amount is known when the transaction is initiated.")]
    TransitKnownFare = BusinessAreaCode.TransitKnownFare, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates when the card is used in an energy business case where the amount could not be assessed when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;EOPT&quot;.
    /// </summary>
    [EnumMember(Value = "EOPT")]
    [IsoId("_taKWAXC7Ee2bmOA3bkVsMg")]
    [Description(@"Indicates when the card is used in an energy business case where the amount could not be assessed when the transaction is initiated.")]
    EnergyOpenPayment = BusinessAreaCode.EnergyOpenPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates when the card is used in a transit business case where the fare amount is not known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;TOPT&quot;.
    /// </summary>
    [EnumMember(Value = "TOPT")]
    [IsoId("_u81psXC7Ee2bmOA3bkVsMg")]
    [Description(@"Indicates when the card is used in a transit business case where the fare amount is not known when the transaction is initiated.")]
    TransitOpenPayment = BusinessAreaCode.TransitOpenPayment, // same ordinal as derivation source for type conversions
    
}
