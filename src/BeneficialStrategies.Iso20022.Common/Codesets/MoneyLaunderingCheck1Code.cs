// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of money laundering identification procedures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aMj4odp-Ed-ak6NoX_4Aeg_-1435186299")]
[Description(@"Specifies the status of money laundering identification procedures.")]
[DerivedFrom(typeof(MoneyLaunderingCheckCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MoneyLaunderingCheck1Code>))]
#endif
public enum MoneyLaunderingCheck1Code
{
    /// <summary>
    /// Money laundering identification procedures have been carried out by the intermediary.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aMj4otp-Ed-ak6NoX_4Aeg_-1394550883")]
    [Description(
        @"Money laundering identification procedures have been carried out by the intermediary."
    )]
    Passed = MoneyLaunderingCheckCode.Passed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money laundering identification procedures have not been carried out.
    /// Encoded/decoded by serializers as &quot;NOTC&quot;.
    /// </summary>
    [EnumMember(Value = "NOTC")]
    [IsoId("_aMj4o9p-Ed-ak6NoX_4Aeg_-1394550852")]
    [Description(@"Money laundering identification procedures have not been carried out.")]
    NotChecked = MoneyLaunderingCheckCode.NotChecked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money laundering identification procedures have not been carried out because the transaction is below the prescribed limit.
    /// Encoded/decoded by serializers as &quot;EXEM&quot;.
    /// </summary>
    [EnumMember(Value = "EXEM")]
    [IsoId("_aMj4pNp-Ed-ak6NoX_4Aeg_-1394550851")]
    [Description(
        @"Money laundering identification procedures have not been carried out because the transaction is below the prescribed limit."
    )]
    ExemptBelowLimit = MoneyLaunderingCheckCode.ExemptBelowLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money laundering identification procedures have not been carried out because of the transaction type, for example, switch, or because the transaction is being funded from an existing investor account held by the intermediary.
    /// Encoded/decoded by serializers as &quot;CLMO&quot;.
    /// </summary>
    [EnumMember(Value = "CLMO")]
    [IsoId("_aMj4pdp-Ed-ak6NoX_4Aeg_-1394550821")]
    [Description(
        @"Money laundering identification procedures have not been carried out because of the transaction type, for example, switch, or because the transaction is being funded from an existing investor account held by the intermediary."
    )]
    ClientMoneyTypeExempt = MoneyLaunderingCheckCode.ClientMoneyTypeExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money laundering identification procedures have not been carried out because the investor is an authorised credit or financial institution.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_aMj4ptp-Ed-ak6NoX_4Aeg_-1394550820")]
    [Description(
        @"Money laundering identification procedures have not been carried out because the investor is an authorised credit or financial institution."
    )]
    AuthorisedCredit = MoneyLaunderingCheckCode.AuthorisedCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limited money laundering identification procedures have been carried out because it is a one time only transaction and the payment is being made by postal, telephone or electronic transfers from an existing account with an authorised credit or financial institution.
    /// Encoded/decoded by serializers as &quot;POEP&quot;.
    /// </summary>
    [EnumMember(Value = "POEP")]
    [IsoId("_aMj4p9p-Ed-ak6NoX_4Aeg_-1394550791")]
    [Description(
        @"Limited money laundering identification procedures have been carried out because it is a one time only transaction and the payment is being made by postal, telephone or electronic transfers from an existing account with an authorised credit or financial institution."
    )]
    PostalOrElectronicPaymentExempt = MoneyLaunderingCheckCode.PostalOrElectronicPaymentExempt, // same ordinal as derivation source for type conversions
}
