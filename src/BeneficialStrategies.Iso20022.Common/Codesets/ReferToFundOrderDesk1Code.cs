// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the operation is only possible in restricted circumstances.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zaydc9p-Ed-ak6NoX_4Aeg_347400994")]
[Description(@"Indicates that the operation is only possible in restricted circumstances.")]
[DerivedFrom(typeof(HoldingTransferableCode))]
public enum ReferToFundOrderDesk1Code
{
    /// <summary>
    /// Indicates that the operation is only possible in restricted circumstances.
    /// Encoded/decoded by serializers as &quot;RFOD&quot;.
    /// </summary>
    [EnumMember(Value = "RFOD")]
    [IsoId("_ZayddNp-Ed-ak6NoX_4Aeg_-805146800")]
    [Description(@"Indicates that the operation is only possible in restricted circumstances.")]
    ReferToFundOrderDesk = HoldingTransferableCode.ReferToFundOrderDesk, // same ordinal as derivation source for type conversions
}
