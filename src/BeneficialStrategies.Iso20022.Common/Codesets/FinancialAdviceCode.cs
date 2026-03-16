// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if advice has been received from an independent financial advisor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_an-pVNp-Ed-ak6NoX_4Aeg_610878701")]
[Description(@"Specifies if advice has been received from an independent financial advisor.")]
[Derivations(typeof(FinancialAdvice1Code))]
public enum FinancialAdviceCode
{
    /// <summary>
    /// Advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_an-pVdp-Ed-ak6NoX_4Aeg_610878726")]
    [Description(@"Advice has been received from an independent financial advisor.")]
    Received,

    /// <summary>
    /// Advice has not been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_an-pVtp-Ed-ak6NoX_4Aeg_610878727")]
    [Description(@"Advice has not been received from an independent financial advisor.")]
    NotReceived,

    /// <summary>
    /// It is not known whether or not advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_an-pV9p-Ed-ak6NoX_4Aeg_610878743")]
    [Description(
        @"It is not known whether or not advice has been received from an independent financial advisor."
    )]
    Unknown,
}
