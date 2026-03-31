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
[IsoId("_441QsPPwEeihCvvpsmGI2w")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfAmount18Code>))]
#endif
public enum TypeOfAmount18Code
{
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_8FG_cfPwEeihCvvpsmGI2w")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount = TypeOfAmountCode.AuthorisedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Baggage related fees
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_8RmjUfPwEeihCvvpsmGI2w")]
    [Description(@"Baggage related fees")]
    Baggage = TypeOfAmountCode.Baggage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount that has been charged to card account
    /// Encoded/decoded by serializers as &quot;CHTC&quot;.
    /// </summary>
    [EnumMember(Value = "CHTC")]
    [IsoId("_8oTzIfPwEeihCvvpsmGI2w")]
    [Description(@"Amount that has been charged to card account")]
    ChargedToCard = TypeOfAmountCode.ChargedToCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data communication related charges
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_9OOjofPwEeihCvvpsmGI2w")]
    [Description(@"Data communication related charges")]
    Data = TypeOfAmountCode.Data, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTK&quot;.
    /// </summary>
    [EnumMember(Value = "EXTK")]
    [IsoId("__EVwsfPwEeihCvvpsmGI2w")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicket = TypeOfAmountCode.ExchangeTicket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra charges (for example,  minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__Oi1kfPwEeihCvvpsmGI2w")]
    [Description(@"Extra charges (for example,  minibar, etc.)")]
    Extra = TypeOfAmountCode.Extra, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of fare
    /// Encoded/decoded by serializers as &quot;FARE&quot;.
    /// </summary>
    [EnumMember(Value = "FARE")]
    [IsoId("__Wt6IfPwEeihCvvpsmGI2w")]
    [Description(@"Amount of fare")]
    Fare = TypeOfAmountCode.Fare, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance charges
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_AQ64kfPxEeihCvvpsmGI2w")]
    [Description(@"Insurance charges ")]
    Insurance = TypeOfAmountCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of food and beverages
    /// Encoded/decoded by serializers as &quot;FDBV&quot;.
    /// </summary>
    [EnumMember(Value = "FDBV")]
    [IsoId("_BhvnQfPxEeihCvvpsmGI2w")]
    [Description(@"Amount of food and beverages")]
    FoodBeverage = TypeOfAmountCode.FoodBeverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_CUJUkfPxEeihCvvpsmGI2w")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous = TypeOfAmountCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_CbM-0fPxEeihCvvpsmGI2w")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_CgfugfPxEeihCvvpsmGI2w")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone charges
    /// Encoded/decoded by serializers as &quot;PHNE&quot;.
    /// </summary>
    [EnumMember(Value = "PHNE")]
    [IsoId("_C5LUQfPxEeihCvvpsmGI2w")]
    [Description(@"Phone charges")]
    Phone = TypeOfAmountCode.Phone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of prepayment
    /// Encoded/decoded by serializers as &quot;PRPY&quot;.
    /// </summary>
    [EnumMember(Value = "PRPY")]
    [IsoId("_DBx2ofPxEeihCvvpsmGI2w")]
    [Description(@"Amount of prepayment")]
    Prepayment = TypeOfAmountCode.Prepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of charges
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_Eu6t4fPxEeihCvvpsmGI2w")]
    [Description(@"Total amount of charges")]
    Total = TypeOfAmountCode.Total, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTF&quot;.
    /// </summary>
    [EnumMember(Value = "EXTF")]
    [IsoId("_ep3jof4bEei1HdXMz5f0FQ")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicketFee = TypeOfAmountCode.ExchangeTicketFee, // same ordinal as derivation source for type conversions
}
