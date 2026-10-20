// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nLcakVN1EfC0lMwgjvMClw")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TypeOfAmount24Code>))]
public enum TypeOfAmount24Code
{
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_nOK-cVN1EfC0lMwgjvMClw")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount = TypeOfAmountCode.AuthorisedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Baggage related fees
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_nOK-c1N1EfC0lMwgjvMClw")]
    [Description(@"Baggage related fees")]
    Baggage = TypeOfAmountCode.Baggage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cargo Amount.
    /// Encoded/decoded by serializers as &quot;CARG&quot;.
    /// </summary>
    [EnumMember(Value = "CARG")]
    [IsoId("_nOK-dVN1EfC0lMwgjvMClw")]
    [Description(@"Cargo Amount.")]
    Cargo = TypeOfAmountCode.Cargo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount that has been charged to card account
    /// Encoded/decoded by serializers as &quot;CHTC&quot;.
    /// </summary>
    [EnumMember(Value = "CHTC")]
    [IsoId("_nOK-d1N1EfC0lMwgjvMClw")]
    [Description(@"Amount that has been charged to card account")]
    ChargedToCard = TypeOfAmountCode.ChargedToCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount for club fee.
    /// Encoded/decoded by serializers as &quot;CLUB&quot;.
    /// </summary>
    [EnumMember(Value = "CLUB")]
    [IsoId("_nOK-eVN1EfC0lMwgjvMClw")]
    [Description(@"Amount for club fee.")]
    ClubFee = TypeOfAmountCode.ClubFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duty free amount
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_nOK-e1N1EfC0lMwgjvMClw")]
    [Description(@"Duty free amount")]
    DutyFree = TypeOfAmountCode.DutyFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTF&quot;.
    /// </summary>
    [EnumMember(Value = "EXTF")]
    [IsoId("_nOK-f1N1EfC0lMwgjvMClw")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicketFee = TypeOfAmountCode.ExchangeTicketFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTK&quot;.
    /// </summary>
    [EnumMember(Value = "EXTK")]
    [IsoId("_nOK-fVN1EfC0lMwgjvMClw")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicket = TypeOfAmountCode.ExchangeTicket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra charges (for example, minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_nOK-gVN1EfC0lMwgjvMClw")]
    [Description(@"Extra charges (for example, minibar, etc.)")]
    Extra = TypeOfAmountCode.Extra, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fare
    /// Encoded/decoded by serializers as &quot;FARE&quot;.
    /// </summary>
    [EnumMember(Value = "FARE")]
    [IsoId("_nOK-g1N1EfC0lMwgjvMClw")]
    [Description(@"Amount of fare")]
    Fare = TypeOfAmountCode.Fare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of food and beverages
    /// Encoded/decoded by serializers as &quot;FDBV&quot;.
    /// </summary>
    [EnumMember(Value = "FDBV")]
    [IsoId("_nOK-hVN1EfC0lMwgjvMClw")]
    [Description(@"Amount of food and beverages")]
    FoodBeverage = TypeOfAmountCode.FoodBeverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_nOK-nVN1EfC0lMwgjvMClw")]
    [Description(@"Fees.")]
    Fees = TypeOfAmountCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance charges
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_nOK-h1N1EfC0lMwgjvMClw")]
    [Description(@"Insurance charges")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_nOK-iVN1EfC0lMwgjvMClw")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pet carrier.
    /// Encoded/decoded by serializers as &quot;PETC&quot;.
    /// </summary>
    [EnumMember(Value = "PETC")]
    [IsoId("_nOK-j1N1EfC0lMwgjvMClw")]
    [Description(@"Pet carrier.")]
    PetCarrier = TypeOfAmountCode.PetCarrier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone charges
    /// Encoded/decoded by serializers as &quot;PHNE&quot;.
    /// </summary>
    [EnumMember(Value = "PHNE")]
    [IsoId("_nOK-kVN1EfC0lMwgjvMClw")]
    [Description(@"Phone charges")]
    Phone = TypeOfAmountCode.Phone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of prepayment
    /// Encoded/decoded by serializers as &quot;PRPY&quot;.
    /// </summary>
    [EnumMember(Value = "PRPY")]
    [IsoId("_nOK-k1N1EfC0lMwgjvMClw")]
    [Description(@"Amount of prepayment")]
    Prepayment = TypeOfAmountCode.Prepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticket delivery amount.
    /// Encoded/decoded by serializers as &quot;TKDL&quot;.
    /// </summary>
    [EnumMember(Value = "TKDL")]
    [IsoId("_nOK-m1N1EfC0lMwgjvMClw")]
    [Description(@"Ticket delivery amount.")]
    TicketDelivery = TypeOfAmountCode.TicketDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of charges
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_nOK-lVN1EfC0lMwgjvMClw")]
    [Description(@"Total amount of charges")]
    Total = TypeOfAmountCode.Total, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tour order amount.
    /// Encoded/decoded by serializers as &quot;TOUR&quot;.
    /// </summary>
    [EnumMember(Value = "TOUR")]
    [IsoId("_nOK-l1N1EfC0lMwgjvMClw")]
    [Description(@"Tour order amount.")]
    TourOrder = TypeOfAmountCode.TourOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount for an upgrade.
    /// Encoded/decoded by serializers as &quot;UPGD&quot;.
    /// </summary>
    [EnumMember(Value = "UPGD")]
    [IsoId("_nOK-mVN1EfC0lMwgjvMClw")]
    [Description(@"Amount for an upgrade.")]
    Upgrade = TypeOfAmountCode.Upgrade, // same ordinal as derivation source for type conversions
}
