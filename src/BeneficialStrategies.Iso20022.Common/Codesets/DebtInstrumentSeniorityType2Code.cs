// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the seniority type of a specific debt instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zp2jMEEPEeWwF-kIleVYXQ")]
[Description(@"Specifies the seniority type of a specific debt instrument.")]
[DerivedFrom(typeof(DebtInstrumentSeniorityTypeCode))]
public enum DebtInstrumentSeniorityType2Code
{
    /// <summary>
    /// Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.
    /// Encoded/decoded by serializers as &quot;SBOD&quot;.
    /// </summary>
    [EnumMember(Value = "SBOD")]
    [IsoId("_dHThgUEPEeWwF-kIleVYXQ")]
    [Description(
        @"Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met."
    )]
    SubordinatedDebt = DebtInstrumentSeniorityTypeCode.SubordinatedDebt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.
    /// Encoded/decoded by serializers as &quot;SNDB&quot;.
    /// </summary>
    [EnumMember(Value = "SNDB")]
    [IsoId("_dZ-l4UEPEeWwF-kIleVYXQ")]
    [Description(
        @"Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer."
    )]
    SeniorDebt = DebtInstrumentSeniorityTypeCode.SeniorDebt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of debts.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ds3ssUEPEeWwF-kIleVYXQ")]
    [Description(@"Other type of debts.")]
    Other = DebtInstrumentSeniorityTypeCode.Other, // same ordinal as derivation source for type conversions
}
