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
[IsoId("_aMj4qNp-Ed-ak6NoX_4Aeg_-1506297478")]
[Description(@"Specifies the status of money laundering identification procedures.")]
[Derivations(typeof(MoneyLaunderingCheck1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MoneyLaunderingCheckCode>))]
#endif
public enum MoneyLaunderingCheckCode
{
    /// <summary>
    /// Money laundering identification procedures have been carried out by the intermediary.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aMtCkNp-Ed-ak6NoX_4Aeg_-1478590595")]
    [Description(
        @"Money laundering identification procedures have been carried out by the intermediary."
    )]
    Passed,

    /// <summary>
    /// Money laundering identification procedures have not been carried out.
    /// Encoded/decoded by serializers as &quot;NOTC&quot;.
    /// </summary>
    [EnumMember(Value = "NOTC")]
    [IsoId("_aMtCkdp-Ed-ak6NoX_4Aeg_-1478590317")]
    [Description(@"Money laundering identification procedures have not been carried out.")]
    NotChecked,

    /// <summary>
    /// Money laundering identification procedures have not been carried out because the transaction is below the prescribed limit.
    /// Encoded/decoded by serializers as &quot;EXEM&quot;.
    /// </summary>
    [EnumMember(Value = "EXEM")]
    [IsoId("_aMtCktp-Ed-ak6NoX_4Aeg_-1478590286")]
    [Description(
        @"Money laundering identification procedures have not been carried out because the transaction is below the prescribed limit."
    )]
    ExemptBelowLimit,

    /// <summary>
    /// Money laundering identification procedures have not been carried out because of the transaction type, for example, switch, or because the transaction is being funded from an existing investor account held by the intermediary.
    /// Encoded/decoded by serializers as &quot;CLMO&quot;.
    /// </summary>
    [EnumMember(Value = "CLMO")]
    [IsoId("_aMtCk9p-Ed-ak6NoX_4Aeg_-1478590285")]
    [Description(
        @"Money laundering identification procedures have not been carried out because of the transaction type, for example, switch, or because the transaction is being funded from an existing investor account held by the intermediary."
    )]
    ClientMoneyTypeExempt,

    /// <summary>
    /// Money laundering identification procedures have not been carried out because the investor is an authorised credit or financial institution.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_aMtClNp-Ed-ak6NoX_4Aeg_-1478590255")]
    [Description(
        @"Money laundering identification procedures have not been carried out because the investor is an authorised credit or financial institution."
    )]
    AuthorisedCredit,

    /// <summary>
    /// Limited money laundering identification procedures have been carried out because it is a one time only transaction and the payment is being made by postal, telephone or electronic transfers from an existing account with an authorised credit or financial institution.
    /// Encoded/decoded by serializers as &quot;POEP&quot;.
    /// </summary>
    [EnumMember(Value = "POEP")]
    [IsoId("_aMtCldp-Ed-ak6NoX_4Aeg_-1478590254")]
    [Description(
        @"Limited money laundering identification procedures have been carried out because it is a one time only transaction and the payment is being made by postal, telephone or electronic transfers from an existing account with an authorised credit or financial institution."
    )]
    PostalOrElectronicPaymentExempt,
}
