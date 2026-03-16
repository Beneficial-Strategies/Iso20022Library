// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMCounterType3Code")]
[Description(@"Type of ATM cassette counters.")]
[DerivedFrom(typeof(ATMCounterTypeV2Code))]
public enum ATMCounterType3Code
{
    /// <summary>
    /// Counters since the beginning of the business day.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_ATMCounterType3Code_BusinessDay")]
    [Description(@"Counters since the beginning of the business day.")]
    BusinessDay = ATMCounterTypeV2Code.BusinessDay,

    /// <summary>
    /// Counters since the last cut-off.
    /// Encoded/decoded by serializers as &quot;CTOF&quot;.
    /// </summary>
    [EnumMember(Value = "CTOF")]
    [IsoId("_ATMCounterType3Code_CutOff")]
    [Description(@"Counters since the last cut-off.")]
    CutOff = ATMCounterTypeV2Code.CutOff,

    /// <summary>
    /// Counters for a customer transaction.
    /// Encoded/decoded by serializers as &quot;CTXN&quot;.
    /// </summary>
    [EnumMember(Value = "CTXN")]
    [IsoId("_ATMCounterType3Code_CustomerTransaction")]
    [Description(@"Counters for a customer transaction.")]
    CustomerTransaction = ATMCounterTypeV2Code.CustomerTransaction,

    /// <summary>
    /// Counters since the last counters inquiry.
    /// Encoded/decoded by serializers as &quot;INQU&quot;.
    /// </summary>
    [EnumMember(Value = "INQU")]
    [IsoId("_ATMCounterType3Code_CountersInquiry")]
    [Description(@"Counters since the last counters inquiry.")]
    CountersInquiry = ATMCounterTypeV2Code.CountersInquiry,

    /// <summary>
    /// Counters since the last update by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_ATMCounterType3Code_OperatorAdjust")]
    [Description(@"Counters since the last update by an operator on the ATM.")]
    OperatorAdjust = ATMCounterTypeV2Code.OperatorAdjust,

    /// <summary>
    /// Counters as a result of some replenishment operation carried out by an operator (for example adding cash to a cash unit).
    /// Encoded/decoded by serializers as &quot;PRTN&quot;.
    /// </summary>
    [EnumMember(Value = "PRTN")]
    [IsoId("_ATMCounterType3Code_Operation")]
    [Description(@"Counters as a result of some replenishment operation carried out by an operator (for example adding cash to a cash unit).")]
    Operation = ATMCounterTypeV2Code.Operation,

    /// <summary>
    /// Counters since last replenishment point.
    /// Encoded/decoded by serializers as &quot;SLRP&quot;.
    /// </summary>
    [EnumMember(Value = "SLRP")]
    [IsoId("_ATMCounterType3Code_SinceLastReplenishmentPoint")]
    [Description(@"Counters since last replenishment point.")]
    SinceLastReplenishmentPoint = ATMCounterTypeV2Code.SinceLastReplenishmentPoint,

}
