// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xptMsJJEEeuuktRxxQZoNQ")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount20Code
{
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_Sxu9gZJFEeuuktRxxQZoNQ")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount = TypeOfAmountCode.AuthorisedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Baggage related fees
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_S5tNwZJFEeuuktRxxQZoNQ")]
    [Description(@"Baggage related fees")]
    Baggage = TypeOfAmountCode.Baggage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cargo Amount.
    /// Encoded/decoded by serializers as &quot;CARG&quot;.
    /// </summary>
    [EnumMember(Value = "CARG")]
    [IsoId("_TWZw0JJFEeuuktRxxQZoNQ")]
    [Description(@"Cargo Amount.")]
    Cargo = TypeOfAmountCode.Cargo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount that has been charged to card account
    /// Encoded/decoded by serializers as &quot;CHTC&quot;.
    /// </summary>
    [EnumMember(Value = "CHTC")]
    [IsoId("_VjHgAZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount that has been charged to card account")]
    ChargedToCard = TypeOfAmountCode.ChargedToCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount for club fee.
    /// Encoded/decoded by serializers as &quot;CLUB&quot;.
    /// </summary>
    [EnumMember(Value = "CLUB")]
    [IsoId("_V9Cb4ZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount for club fee.")]
    ClubFee = TypeOfAmountCode.ClubFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duty free amount
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_ZKsDoZJFEeuuktRxxQZoNQ")]
    [Description(@"Duty free amount")]
    DutyFree = TypeOfAmountCode.DutyFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTK&quot;.
    /// </summary>
    [EnumMember(Value = "EXTK")]
    [IsoId("_ZVflcZJFEeuuktRxxQZoNQ")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicket = TypeOfAmountCode.ExchangeTicket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTF&quot;.
    /// </summary>
    [EnumMember(Value = "EXTF")]
    [IsoId("_Zdu7cZJFEeuuktRxxQZoNQ")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicketFee = TypeOfAmountCode.ExchangeTicketFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra charges (for example,  minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_Zs9qQZJFEeuuktRxxQZoNQ")]
    [Description(@"Extra charges (for example,  minibar, etc.)")]
    Extra = TypeOfAmountCode.Extra, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fare
    /// Encoded/decoded by serializers as &quot;FARE&quot;.
    /// </summary>
    [EnumMember(Value = "FARE")]
    [IsoId("_Z8tWcZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount of fare")]
    Fare = TypeOfAmountCode.Fare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of food and beverages
    /// Encoded/decoded by serializers as &quot;FDBV&quot;.
    /// </summary>
    [EnumMember(Value = "FDBV")]
    [IsoId("_aPyqgZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount of food and beverages")]
    FoodBeverage = TypeOfAmountCode.FoodBeverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance charges
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_cSosAZJFEeuuktRxxQZoNQ")]
    [Description(@"Insurance charges ")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_dpgYUZJFEeuuktRxxQZoNQ")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_erNF4ZJFEeuuktRxxQZoNQ")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_e4zdAZJFEeuuktRxxQZoNQ")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pet carrier.
    /// Encoded/decoded by serializers as &quot;PETC&quot;.
    /// </summary>
    [EnumMember(Value = "PETC")]
    [IsoId("_fG0D0ZJFEeuuktRxxQZoNQ")]
    [Description(@"Pet carrier.")]
    PetCarrier = TypeOfAmountCode.PetCarrier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone charges
    /// Encoded/decoded by serializers as &quot;PHNE&quot;.
    /// </summary>
    [EnumMember(Value = "PHNE")]
    [IsoId("_fPznwZJFEeuuktRxxQZoNQ")]
    [Description(@"Phone charges")]
    Phone = TypeOfAmountCode.Phone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of prepayment
    /// Encoded/decoded by serializers as &quot;PRPY&quot;.
    /// </summary>
    [EnumMember(Value = "PRPY")]
    [IsoId("_ffnlYZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount of prepayment")]
    Prepayment = TypeOfAmountCode.Prepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of charges
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_hCefQZJFEeuuktRxxQZoNQ")]
    [Description(@"Total amount of charges")]
    Total = TypeOfAmountCode.Total, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tour order amount.
    /// Encoded/decoded by serializers as &quot;TOUR&quot;.
    /// </summary>
    [EnumMember(Value = "TOUR")]
    [IsoId("_hUNvgZJFEeuuktRxxQZoNQ")]
    [Description(@"Tour order amount.")]
    TourOrder = TypeOfAmountCode.TourOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount for an upgrade.
    /// Encoded/decoded by serializers as &quot;UPGD&quot;.
    /// </summary>
    [EnumMember(Value = "UPGD")]
    [IsoId("_inEegZJFEeuuktRxxQZoNQ")]
    [Description(@"Amount for an upgrade.")]
    Upgrade = TypeOfAmountCode.Upgrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticket delivery amount.
    /// Encoded/decoded by serializers as &quot;TKDL&quot;.
    /// </summary>
    [EnumMember(Value = "TKDL")]
    [IsoId("_onjaQZJFEeuuktRxxQZoNQ")]
    [Description(@"Ticket delivery amount.")]
    TicketDelivery = TypeOfAmountCode.TicketDelivery, // same ordinal as derivation source for type conversions
}
