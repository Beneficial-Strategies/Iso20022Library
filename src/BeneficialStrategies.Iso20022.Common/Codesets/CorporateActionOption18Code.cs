// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oAT98A7VEfC-6PbsYHIdig")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionOption18Code>))]
public enum CorporateActionOption18Code
{
    /// <summary>
    /// Abstain.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_oKnJcQ7VEfC-6PbsYHIdig")]
    [Description(@"Abstain.")]
    Abstain = CorporateActionOptionCode.Abstain,

    /// <summary>
    /// Bonus share plan.
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_oKnJcw7VEfC-6PbsYHIdig")]
    [Description(@"Bonus share plan.")]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan,

    /// <summary>
    /// Cash and security.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_oKnJdw7VEfC-6PbsYHIdig")]
    [Description(@"Cash and security.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity,

    /// <summary>
    /// Cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_oKnJeQ7VEfC-6PbsYHIdig")]
    [Description(@"Cash.")]
    Cash = CorporateActionOptionCode.Cash,

    /// <summary>
    /// Consent and exchange.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_oKnJew7VEfC-6PbsYHIdig")]
    [Description(@"Consent and exchange.")]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange,

    /// <summary>
    /// Consent denied.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_oKnJfQ7VEfC-6PbsYHIdig")]
    [Description(@"Consent denied.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied,

    /// <summary>
    /// Consent granted.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_oKnJfw7VEfC-6PbsYHIdig")]
    [Description(@"Consent granted.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted,

    /// <summary>
    /// Consent and tender.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_oKnJgQ7VEfC-6PbsYHIdig")]
    [Description(@"Consent and tender.")]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender,

    /// <summary>
    /// Exercise.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_oKnJgw7VEfC-6PbsYHIdig")]
    [Description(@"Exercise.")]
    Exercise = CorporateActionOptionCode.Exercise,

    /// <summary>
    /// Lapse.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_oKnJhQ7VEfC-6PbsYHIdig")]
    [Description(@"Lapse.")]
    Lapse = CorporateActionOptionCode.Lapse,

    /// <summary>
    /// Retain.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_oKnJhw7VEfC-6PbsYHIdig")]
    [Description(@"Retain.")]
    Retain = CorporateActionOptionCode.Retain,

    /// <summary>
    /// No action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_oKnJiQ7VEfC-6PbsYHIdig")]
    [Description(@"No action.")]
    NoAction = CorporateActionOptionCode.NoAction,

    /// <summary>
    /// Proposed rate.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_oKnJjQ7VEfC-6PbsYHIdig")]
    [Description(@"Proposed rate.")]
    ProposedRate = CorporateActionOptionCode.ProposedRate,

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_oKnJjw7VEfC-6PbsYHIdig")]
    [Description(@"Other.")]
    Other = CorporateActionOptionCode.Other,

    /// <summary>
    /// Oversubscribe.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_oKnJkQ7VEfC-6PbsYHIdig")]
    [Description(@"Oversubscribe.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe,

    /// <summary>
    /// Security.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_oKnJlQ7VEfC-6PbsYHIdig")]
    [Description(@"Security.")]
    Security = CorporateActionOptionCode.Security,

    /// <summary>
    /// Unknown proceeds.
    /// Encoded/decoded by serializers as &quot;PRUN&quot;.
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_oKnJmQ7VEfC-6PbsYHIdig")]
    [Description(@"Unknown proceeds.")]
    UnknownProceeds = CorporateActionOptionCode.UnknownProceeds,
}
