// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VeXEJtp-Ed-ak6NoX_4Aeg_313498033")]
[Description(@"Type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType4Code
{
    /// <summary>
    /// In investment funds, a fee charged for the transfer of ownership of an investment fund.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_VeXEJ9p-Ed-ak6NoX_4Aeg_313498035")]
    [Description(
        @"In investment funds, a fee charged for the transfer of ownership of an investment fund."
    )]
    TransferFee = ChargeTypeCode.TransferFee, // same ordinal as derivation source for type conversions
}
