// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EG1A4aH_EeuiuNcvKhXmNQ")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount21Code
{
    /// <summary>
    /// Interchange fee.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_EL_NsaH_EeuiuNcvKhXmNQ")]
    [Description(@"Interchange fee.")]
    InterchangeFee = TypeOfAmountCode.InterchangeFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing fees.
    /// Encoded/decoded by serializers as &quot;FEEP&quot;.
    /// </summary>
    [EnumMember(Value = "FEEP")]
    [IsoId("_EL_Ns6H_EeuiuNcvKhXmNQ")]
    [Description(@"Processing fees.")]
    ProcessingFees = TypeOfAmountCode.ProcessingFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EL_NtaH_EeuiuNcvKhXmNQ")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_EL_Nt6H_EeuiuNcvKhXmNQ")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// International service assessment fees.
    /// Encoded/decoded by serializers as &quot;FEEA&quot;.
    /// </summary>
    [EnumMember(Value = "FEEA")]
    [IsoId("_EL_NuaH_EeuiuNcvKhXmNQ")]
    [Description(@"International service assessment fees.")]
    InternationalServiceAssessmentFees = TypeOfAmountCode.InternationalServiceAssessmentFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interchange fee applicable to cash back amount.
    /// Encoded/decoded by serializers as &quot;CSIF&quot;.
    /// </summary>
    [EnumMember(Value = "CSIF")]
    [IsoId("_UQGKgaH_EeuiuNcvKhXmNQ")]
    [Description(@"Interchange fee applicable to cash back amount.")]
    CashBackInterchangeFee = TypeOfAmountCode.CashBackInterchangeFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum applicable interchange fee.
    /// Encoded/decoded by serializers as &quot;MXIF&quot;.
    /// </summary>
    [EnumMember(Value = "MXIF")]
    [IsoId("_WF3ZUaH_EeuiuNcvKhXmNQ")]
    [Description(@"Maximum applicable interchange fee.")]
    MaximumInterchangeFee = TypeOfAmountCode.MaximumInterchangeFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minimum interchange fee applicable.
    /// Encoded/decoded by serializers as &quot;MNIF&quot;.
    /// </summary>
    [EnumMember(Value = "MNIF")]
    [IsoId("_WpWg4aH_EeuiuNcvKhXmNQ")]
    [Description(@"Minimum interchange fee applicable.")]
    MinimumInterchangeFee = TypeOfAmountCode.MinimumInterchangeFee, // same ordinal as derivation source for type conversions
    
}
