// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if advice has been received from an independent financial advisor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_an-pUNp-Ed-ak6NoX_4Aeg_126030159")]
[Description(@"Specifies if advice has been received from an independent financial advisor.")]
[DerivedFrom(typeof(FinancialAdviceCode))]
public enum FinancialAdvice1Code
{
    /// <summary>
    /// Advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_an-pUdp-Ed-ak6NoX_4Aeg_236854692")]
    [Description(@"Advice has been received from an independent financial advisor.")]
    Received = FinancialAdviceCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice has not been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_an-pUtp-Ed-ak6NoX_4Aeg_240547799")]
    [Description(@"Advice has not been received from an independent financial advisor.")]
    NotReceived = FinancialAdviceCode.NotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// It is not known whether or not advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_an-pU9p-Ed-ak6NoX_4Aeg_244241759")]
    [Description(
        @"It is not known whether or not advice has been received from an independent financial advisor."
    )]
    Unknown = FinancialAdviceCode.Unknown, // same ordinal as derivation source for type conversions
}
