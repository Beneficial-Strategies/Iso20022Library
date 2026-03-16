// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jPdhsO5NEeCisYr99QEiWA_1476260679")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum LimitType4Code
{
    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank.
    /// Encoded/decoded by serializers as &quot;EXGT&quot;.
    /// </summary>
    [EnumMember(Value = "EXGT")]
    [IsoId("_jPdhse5NEeCisYr99QEiWA_-1234776902")]
    [Description(
        @"Limit is related to a cap amount granted by a national central bank or a settlement bank."
    )]
    ExternalGuarantee = LimitTypeCode.ExternalGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure.
    /// Encoded/decoded by serializers as &quot;UCDT&quot;.
    /// </summary>
    [EnumMember(Value = "UCDT")]
    [IsoId("_jPdhsu5NEeCisYr99QEiWA_-1814191119")]
    [Description(
        @"Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure."
    )]
    UnsecuredCredit = LimitTypeCode.UnsecuredCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”).
    /// Encoded/decoded by serializers as &quot;ACOL&quot;.
    /// </summary>
    [EnumMember(Value = "ACOL")]
    [IsoId("_jPdhs-5NEeCisYr99QEiWA_-1669106499")]
    [Description(
        @"Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”)."
    )]
    AutoCollateralisation = LimitTypeCode.AutoCollateralisation, // same ordinal as derivation source for type conversions
}
