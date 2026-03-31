// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the business context of the transaction
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9UR8E4NEey_VecAUE-C9Q")]
[Description(@"Specifies the business context of the transaction")]
[Derivations(typeof(BusinessArea1Code), typeof(BusinessArea2Code))]
public enum BusinessAreaCode
{
    /// <summary>
    /// The card is used to perform a plain payment.
    /// Encoded/decoded by serializers as &quot;PPAY&quot;.
    /// </summary>
    [EnumMember(Value = "PPAY")]
    [IsoId("_uS3KUE4NEey_VecAUE-C9Q")]
    [Description(@"The card is used to perform a plain payment.")]
    PlainPayment,

    /// <summary>
    /// The card is used in a Transit business case where the fare amount is not known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;OPMT&quot;.
    /// </summary>
    [EnumMember(Value = "OPMT")]
    [IsoId("_zwl-UE4NEey_VecAUE-C9Q")]
    [Description(
        @"The card is used in a Transit business case where the fare amount is not known when the transaction is initiated."
    )]
    Openpayment,

    /// <summary>
    /// The card is used in a Transit business case where the fare amount is known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;TKNF&quot;.
    /// </summary>
    [EnumMember(Value = "TKNF")]
    [IsoId("_4Kzf0E4NEey_VecAUE-C9Q")]
    [Description(
        @"The card is used in a Transit business case where the fare amount is known when the transaction is initiated."
    )]
    TransitKnownFare,

    /// <summary>
    /// The payment is initiated by an artificial intelligence based decision.
    /// Encoded/decoded by serializers as &quot;AIBD&quot;.
    /// </summary>
    [EnumMember(Value = "AIBD")]
    [IsoId("_9NsK4E4NEey_VecAUE-C9Q")]
    [Description(@"The payment is initiated by an artificial intelligence based decision.")]
    ArtificialIntelligenceBasedDecision,

    /// <summary>
    /// Indicates when the card is used in an energy business case where the amount could not be assessed when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;EOPT&quot;.
    /// </summary>
    [EnumMember(Value = "EOPT")]
    [IsoId("_OdgGAHC6Ee2bmOA3bkVsMg")]
    [Description(
        @"Indicates when the card is used in an energy business case where the amount could not be assessed when the transaction is initiated."
    )]
    EnergyOpenPayment,

    /// <summary>
    /// Indicates when the card is used in a transit business case where the fare amount is not known when the transaction is initiated.
    /// Encoded/decoded by serializers as &quot;TOPT&quot;.
    /// </summary>
    [EnumMember(Value = "TOPT")]
    [IsoId("_QOkbAHC6Ee2bmOA3bkVsMg")]
    [Description(
        @"Indicates when the card is used in a transit business case where the fare amount is not known when the transaction is initiated."
    )]
    TransitOpenPayment,
}
