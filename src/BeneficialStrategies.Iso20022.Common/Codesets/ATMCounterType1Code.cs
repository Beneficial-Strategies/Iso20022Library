// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-bKw0IqiEeS4a4abTJTSSw")]
[Description(@"Type of ATM cassette counters.")]
[DerivedFrom(typeof(ATMCounterTypeCode))]
public enum ATMCounterType1Code
{
    /// <summary>
    /// Counters since the last counters inquiry.
    /// Encoded/decoded by serializers as &quot;INQU&quot;.
    /// </summary>
    [EnumMember(Value = "INQU")]
    [IsoId("_InqOYeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last counters inquiry.")]
    CountersInquiry = ATMCounterTypeCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters for a customer transaction.
    /// Encoded/decoded by serializers as &quot;CTXN&quot;.
    /// </summary>
    [EnumMember(Value = "CTXN")]
    [IsoId("_IvHhQeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters for a customer transaction.")]
    CustomerTransaction = ATMCounterTypeCode.CustomerTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the last cut-off.
    /// Encoded/decoded by serializers as &quot;CTOF&quot;.
    /// </summary>
    [EnumMember(Value = "CTOF")]
    [IsoId("_I1X6Qeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last cut-off.")]
    CutOff = ATMCounterTypeCode.CutOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the beginning of the business day.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_I7fJUeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters since the beginning of the business day.")]
    BusinessDay = ATMCounterTypeCode.BusinessDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters for an operation performed by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;PRTN&quot;.
    /// </summary>
    [EnumMember(Value = "PRTN")]
    [IsoId("_JBviUeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters for an operation performed by an operator on the ATM.")]
    Operation = ATMCounterTypeCode.Operation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counters since the last update by an operator on the ATM.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_JImYQeg3EeSbwP3G-MV9YA")]
    [Description(@"Counters since the last update by an operator on the ATM.")]
    OperatorAdjust = ATMCounterTypeCode.OperatorAdjust, // same ordinal as derivation source for type conversions
    
}
