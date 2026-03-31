// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KjGSMDEqEemzCpWiCwK4aQ")]
[Description(@"Contains the details of the grace period applicable to the instalment.")]
[DerivedFrom(typeof(InstalmentAmountDetailsTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstalmentAmountDetailsType1Code>))]
#endif
public enum InstalmentAmountDetailsType1Code
{
    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as &quot;TAXX&quot;.
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_N8-YETEqEemzCpWiCwK4aQ")]
    [Description(@"Instalment amount tax")]
    Tax = InstalmentAmountDetailsTypeCode.Tax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_ORPX4TEqEemzCpWiCwK4aQ")]
    [Description(@"Requested amount")]
    Requested = InstalmentAmountDetailsTypeCode.Requested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Olz5sTEqEemzCpWiCwK4aQ")]
    [Description(@"Grace period unit type")]
    OtherPrivate = InstalmentAmountDetailsTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_O6hlcTEqEemzCpWiCwK4aQ")]
    [Description(@"Grace period unit type")]
    OtherNational = InstalmentAmountDetailsTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_PO8WQTEqEemzCpWiCwK4aQ")]
    [Description(@"Other amounts")]
    OtherCharges = InstalmentAmountDetailsTypeCode.OtherCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_PjXHETEqEemzCpWiCwK4aQ")]
    [Description(@"Insurance amount")]
    Insurance = InstalmentAmountDetailsTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as &quot;FUNA&quot;.
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_P4N8wTEqEemzCpWiCwK4aQ")]
    [Description(@"Funded amount")]
    Funded = InstalmentAmountDetailsTypeCode.Funded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_QNYUcTEqEemzCpWiCwK4aQ")]
    [Description(@"Fees amount")]
    Fees = InstalmentAmountDetailsTypeCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_QiZiMTEqEemzCpWiCwK4aQ")]
    [Description(@"Expense Amount")]
    Expense = InstalmentAmountDetailsTypeCode.Expense, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as &quot;AFCO&quot;.
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_DL1y4ekYEemeDPHh-U9b6w")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost = InstalmentAmountDetailsTypeCode.AnnualFinancingCost, // same ordinal as derivation source for type conversions
}
