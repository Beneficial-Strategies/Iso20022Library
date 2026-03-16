// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter &quot;Variable&quot; if the status of the fund is likely to change from time to time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ai58Edp-Ed-ak6NoX_4Aeg_-428222749")]
[Description(
    @"Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter ""Variable"" if the status of the fund is likely to change from time to time."
)]
[Derivations(typeof(EUSavingsDirective1Code))]
public enum EUSavingsDirectiveCode
{
    /// <summary>
    /// Investment Fund is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSI&quot;.
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_ai58Etp-Ed-ak6NoX_4Aeg_-1192571141")]
    [Description(@"Investment Fund is in the scope of the directive.")]
    EUSavingsInScope,

    /// <summary>
    /// Investment Fund is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSO&quot;.
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_ai58E9p-Ed-ak6NoX_4Aeg_-1192571140")]
    [Description(@"Investment Fund is out of the scope of the directive.")]
    EUSavingsOutScope,

    /// <summary>
    /// Unknown whether capital gain is in or out of the scope fo the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ai58FNp-Ed-ak6NoX_4Aeg_-1192571119")]
    [Description(@"Unknown whether capital gain is in or out of the scope fo the directive.")]
    EUSavingsUnknown,

    /// <summary>
    /// Investment Fund may vary for inclusion in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ai58Fdp-Ed-ak6NoX_4Aeg_339285326")]
    [Description(@"Investment Fund may vary for inclusion in the scope of the directive.")]
    EUSavingsVariable,
}
