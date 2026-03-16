// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vSNNoIqiEeS4a4abTJTSSw")]
[Description(@"Type of ATM cassette counters.")]
[Derivations(typeof(ATMCounterType1Code), typeof(ATMCounterType2Code))]
public enum ATMCounterTypeCode
{
    /// <summary>
    /// Counters since the last cut-off.
    /// Encoded/decoded by serializers as &quot;CTOF&quot;.
    /// </summary>
    [EnumMember(Value = "CTOF")]
    [IsoId("_zjMhsIqiEeS4a4abTJTSSw")]
    [Description(@"Counters since the last cut-off.")]
    CutOff,

    /// <summary>
    /// Counters since the last update by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_3CFqcIqiEeS4a4abTJTSSw")]
    [Description(@"Counters since the last update by an operator on the ATM.")]
    OperatorAdjust,

    /// <summary>
    /// Counters since the last counters inquiry.
    /// Encoded/decoded by serializers as &quot;INQU&quot;.
    /// </summary>
    [EnumMember(Value = "INQU")]
    [IsoId("_iszAsOg2EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last counters inquiry.")]
    CountersInquiry,

    /// <summary>
    /// Counters for a customer transaction.
    /// Encoded/decoded by serializers as &quot;CTXN&quot;.
    /// </summary>
    [EnumMember(Value = "CTXN")]
    [IsoId("_nIHVcOg2EeSbwP3G-MV9YA")]
    [Description(@"Counters for a customer transaction.")]
    CustomerTransaction,

    /// <summary>
    /// Counters since the beginning of the business day.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_q0zpoOg2EeSbwP3G-MV9YA")]
    [Description(@"Counters since the beginning of the business day.")]
    BusinessDay,

    /// <summary>
    /// Counters for an operation performed by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;PRTN&quot;.
    /// </summary>
    [EnumMember(Value = "PRTN")]
    [IsoId("_uJyBYOg2EeSbwP3G-MV9YA")]
    [Description(@"Counters for an operation performed by an operator on the ATM.")]
    Operation,
}
