// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is an increase or a decrease or the result of a reversal operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boymFdp-Ed-ak6NoX_4Aeg_-1616551496")]
[Description(
    @"Specifies if an operation is an increase or a decrease or the result of a reversal operation."
)]
[Derivations(typeof(CreditDebitCode), typeof(ReversalCode), typeof(CreditDebit3Code))]
public enum AmountDirectionCode
{
    /// <summary>
    /// Operation is a decrease.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_boymFtp-Ed-ak6NoX_4Aeg_-1454013233")]
    [Description(@"Operation is a decrease.")]
    Debit,

    /// <summary>
    /// Operation is an increase.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_boymF9p-Ed-ak6NoX_4Aeg_-1454013216")]
    [Description(@"Operation is an increase.")]
    Credit,

    /// <summary>
    /// Credit entry used to reverse a previously booked debit entry.
    /// Encoded/decoded by serializers as &quot;RVDB&quot;.
    /// </summary>
    [EnumMember(Value = "RVDB")]
    [IsoId("_boymGNp-Ed-ak6NoX_4Aeg_-1454013198")]
    [Description(@"Credit entry used to reverse a previously booked debit entry.")]
    ReversalDebit,

    /// <summary>
    /// Debit entry used to reverse a previously booked credit entry.
    /// Encoded/decoded by serializers as &quot;RVCD&quot;.
    /// </summary>
    [EnumMember(Value = "RVCD")]
    [IsoId("_bo8XENp-Ed-ak6NoX_4Aeg_-1454013156")]
    [Description(@"Debit entry used to reverse a previously booked credit entry.")]
    ReversalCredit,
}
