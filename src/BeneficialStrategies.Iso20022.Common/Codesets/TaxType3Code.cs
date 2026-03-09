// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ykix9dp-Ed-ak6NoX_4Aeg_1780697405")]
[Description(@"Type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType3Code
{
    /// <summary>
    /// Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as &quot;LIDT&quot;.
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_Ykix9tp-Ed-ak6NoX_4Aeg_1780697407")]
    [Description(@"Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    GermanLocalTax2 = TaxTypeCode.GermanLocalTax2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_Ykix99p-Ed-ak6NoX_4Aeg_1780697436")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax = TaxTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_Ykix-Np-Ed-ak6NoX_4Aeg_1780697437")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax = TaxTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions
    
}
