// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the tax calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vd10pqlEeGSON8vddiWzQ_-401381436")]
[Description(@"Defines the tax calculation method.")]
[DerivedFrom(typeof(BillingTaxCalculationMethodCode))]
public enum BillingTaxCalculationMethod1Code
{
    /// <summary>
    /// No taxes are calculated or due on this account.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_6Vd105qlEeGSON8vddiWzQ_-1535157938")]
    [Description(@"No taxes are calculated or due on this account.")]
    NoTaxes = BillingTaxCalculationMethodCode.NoTaxes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Line-by-line per service calculation and settlement currency translation.
    /// Encoded/decoded by serializers as &quot;MTDA&quot;.
    /// </summary>
    [EnumMember(Value = "MTDA")]
    [IsoId("_6Vd11JqlEeGSON8vddiWzQ_1775205103")]
    [Description(@"Line-by-line per service calculation and settlement currency translation.")]
    MethodA = BillingTaxCalculationMethodCode.MethodA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Line-by-line per service calculation with settlement currency translation performed on the statement tax total.
    /// Encoded/decoded by serializers as &quot;MTDB&quot;.
    /// </summary>
    [EnumMember(Value = "MTDB")]
    [IsoId("_6Vd11ZqlEeGSON8vddiWzQ_-1052613430")]
    [Description(@"Line-by-line per service calculation with settlement currency translation performed on the statement tax total.")]
    MethodB = BillingTaxCalculationMethodCode.MethodB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Group tax calculation with group settlement currency translation.
    /// Encoded/decoded by serializers as &quot;MTDC&quot;.
    /// </summary>
    [EnumMember(Value = "MTDC")]
    [IsoId("_6Vd11pqlEeGSON8vddiWzQ_1967073441")]
    [Description(@"Group tax calculation with group settlement currency translation.")]
    MethodC = BillingTaxCalculationMethodCode.MethodC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Line-by-line per service calculation with all charges and taxes due in the pricing currency.
    /// Encoded/decoded by serializers as &quot;MTDD&quot;.
    /// </summary>
    [EnumMember(Value = "MTDD")]
    [IsoId("_6Vd115qlEeGSON8vddiWzQ_-2002776348")]
    [Description(@"Line-by-line per service calculation with all charges and taxes due in the pricing currency.")]
    MethodD = BillingTaxCalculationMethodCode.MethodD, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax calculation method is not defined or unknown.
    /// Encoded/decoded by serializers as &quot;UDFD&quot;.
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_6Vd12JqlEeGSON8vddiWzQ_-535627585")]
    [Description(@"Tax calculation method is not defined or unknown.")]
    Undefined = BillingTaxCalculationMethodCode.Undefined, // same ordinal as derivation source for type conversions
    
}
