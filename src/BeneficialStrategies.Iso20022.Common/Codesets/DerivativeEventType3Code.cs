// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Swc0sE2WEe2bQ-Ksk8mwQg")]
[Description(@"Explanation or reason for the action being taken on the transaction reporting.")]
[DerivedFrom(typeof(DerivativeEventTypeV2Code))]
public enum DerivativeEventType3Code
{
    /// <summary>
    /// Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives.
    /// Encoded/decoded by serializers as &quot;ALOC&quot;.
    /// </summary>
    [EnumMember(Value = "ALOC")]
    [IsoId("_hMEJsU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives."
    )]
    Allocation = DerivativeEventTypeV2Code.Allocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer.
    /// Encoded/decoded by serializers as &quot;CLRG&quot;.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_hPOycU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer."
    )]
    Clearing = DerivativeEventTypeV2Code.Clearing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Simultaneous clearing and allocation event in a derivatives clearing organisation.
    /// Encoded/decoded by serializers as &quot;CLAL&quot;.
    /// </summary>
    [EnumMember(Value = "CLAL")]
    [IsoId("_hSjMMU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Simultaneous clearing and allocation event in a derivatives clearing organisation."
    )]
    ClearingAndAllocation = DerivativeEventTypeV2Code.ClearingAndAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Compression or post-trade risk reduction exercise.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_hVekYU2WEe2bQ-Ksk8mwQg")]
    [Description(@"Compression or post-trade risk reduction exercise.")]
    Compression = DerivativeEventTypeV2Code.Compression, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_hYeOAU2WEe2bQ-Ksk8mwQg")]
    [Description(@"Result of a corporate action.")]
    CorporateAction = DerivativeEventTypeV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level.
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_hb1rEU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Applies only to credit derivatives. A credit event that results in a termination or modification of a derivative, at a trade or position level."
    )]
    CreditEvent = DerivativeEventTypeV2Code.CreditEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Termination of an existing derivative transaction prior to scheduled termination or maturity date.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_hfNvMU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Termination of an existing derivative transaction prior to scheduled termination or maturity date."
    )]
    EarlyTermination = DerivativeEventTypeV2Code.EarlyTermination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The exercise of an option or a swaption by one counterparty of the transaction, fully or partially.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_hiPOAU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. "
    )]
    Exercise = DerivativeEventTypeV2Code.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_hlQFwU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified."
    )]
    InclusionInPosition = DerivativeEventTypeV2Code.InclusionInPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.
    /// Encoded/decoded by serializers as &quot;NOVA&quot;.
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_hoeY4U2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"The replacement of a party to a derivative contract with another party giving rise to a new derivative contract."
    )]
    Novation = DerivativeEventTypeV2Code.Novation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The process by which a derivative transaction is transferred to another trade repository using the same UTI.
    /// Encoded/decoded by serializers as &quot;PTNG&quot;.
    /// </summary>
    [EnumMember(Value = "PTNG")]
    [IsoId("_hrposU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"The process by which a derivative transaction is transferred to another trade repository using the same UTI."
    )]
    Porting = DerivativeEventTypeV2Code.Porting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_hx1wQU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty."
    )]
    Trade = DerivativeEventTypeV2Code.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Outstanding derivative is updated to comply with the revised requirements on reporting.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_h1EqcU2WEe2bQ-Ksk8mwQg")]
    [Description(
        @"Outstanding derivative is updated to comply with the revised requirements on reporting."
    )]
    Update = DerivativeEventTypeV2Code.Update, // same ordinal as derivation source for type conversions
}
