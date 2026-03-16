// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the tax calculation method to be used for the billing of the services.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vm_wJqlEeGSON8vddiWzQ_-160980643")]
[Description(@"Defines the tax calculation method to be used for the billing of the services.")]
[Derivations(typeof(BillingTaxCalculationMethod1Code))]
public enum BillingTaxCalculationMethodCode
{
    /// <summary>
    /// No taxes are calculated or due on this account.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_6Vm_wZqlEeGSON8vddiWzQ_-275092404")]
    [Description(@"No taxes are calculated or due on this account.")]
    NoTaxes,

    /// <summary>
    /// Line-by-line per service calculation and settlement currency translation.
    /// Encoded/decoded by serializers as &quot;MTDA&quot;.
    /// </summary>
    [EnumMember(Value = "MTDA")]
    [IsoId("_6Vm_wpqlEeGSON8vddiWzQ_-96973732")]
    [Description(@"Line-by-line per service calculation and settlement currency translation.")]
    MethodA,

    /// <summary>
    /// Line-by-line per service calculation with settlement currency translation performed on the statement tax total.
    /// Encoded/decoded by serializers as &quot;MTDB&quot;.
    /// </summary>
    [EnumMember(Value = "MTDB")]
    [IsoId("_6Vm_w5qlEeGSON8vddiWzQ_-388931470")]
    [Description(
        @"Line-by-line per service calculation with settlement currency translation performed on the statement tax total."
    )]
    MethodB,

    /// <summary>
    /// Group tax calculation with group settlement currency translation.
    /// Encoded/decoded by serializers as &quot;MTDC&quot;.
    /// </summary>
    [EnumMember(Value = "MTDC")]
    [IsoId("_6Vm_xJqlEeGSON8vddiWzQ_1370175031")]
    [Description(@"Group tax calculation with group settlement currency translation.")]
    MethodC,

    /// <summary>
    /// Line-by-line per service calculation with all charges and taxes due in the pricing currency.
    /// Encoded/decoded by serializers as &quot;MTDD&quot;.
    /// </summary>
    [EnumMember(Value = "MTDD")]
    [IsoId("_6Vm_xZqlEeGSON8vddiWzQ_-1272164757")]
    [Description(
        @"Line-by-line per service calculation with all charges and taxes due in the pricing currency."
    )]
    MethodD,

    /// <summary>
    /// Tax calculation method is not defined or unknown.
    /// Encoded/decoded by serializers as &quot;UDFD&quot;.
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_6Vm_xpqlEeGSON8vddiWzQ_-1094046085")]
    [Description(@"Tax calculation method is not defined or unknown.")]
    Undefined,
}
