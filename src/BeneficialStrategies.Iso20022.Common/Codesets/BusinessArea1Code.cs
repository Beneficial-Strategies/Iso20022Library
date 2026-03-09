// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the business context of the transaction
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JfLxsE4OEey_VecAUE-C9Q")]
[Description(@"Specifies the business context of the transaction")]
[DerivedFrom(typeof(BusinessAreaCode))]
public enum BusinessArea1Code
{
    /// <summary>
    /// The payment is initiated by an artificial intelligence based decision.
    /// Encoded/decoded by serializers as &quot;AIBD&quot;.
    /// </summary>
    [EnumMember(Value = "AIBD")]
    [IsoId("_RZiZIU4OEey_VecAUE-C9Q")]
    [Description(@"The payment is initiated by an artificial intelligence based decision.")]
    ArtificialIntelligenceBasedDecision = BusinessAreaCode.ArtificialIntelligenceBasedDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used in a Transit business case where the fare amount is not known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;OPMT&quot;.
    /// </summary>
    [EnumMember(Value = "OPMT")]
    [IsoId("_RgShYU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used in a Transit business case where the fare amount is not known when the transaction is initiated.")]
    Openpayment = BusinessAreaCode.Openpayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used to perform a plain payment.
    /// Encoded/decoded by serializers as &quot;PPAY&quot;.
    /// </summary>
    [EnumMember(Value = "PPAY")]
    [IsoId("_RrhhAU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used to perform a plain payment.")]
    PlainPayment = BusinessAreaCode.PlainPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used in a Transit business case where the fare amount is known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;TKNF&quot;.
    /// </summary>
    [EnumMember(Value = "TKNF")]
    [IsoId("_RzNdYU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used in a Transit business case where the fare amount is known when the transaction is initiated.")]
    TransitKnownFare = BusinessAreaCode.TransitKnownFare, // same ordinal as derivation source for type conversions
    
}
