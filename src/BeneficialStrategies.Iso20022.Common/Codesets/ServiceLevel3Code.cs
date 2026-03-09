// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VwsKQNp-Ed-ak6NoX_4Aeg_-228092499")]
[Description(@"Specifies the pre-agreed level of service between the parties.")]
[DerivedFrom(typeof(ServiceLevelCode))]
public enum ServiceLevel3Code
{
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_VwsKQdp-Ed-ak6NoX_4Aeg_-228092481")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea = ServiceLevelCode.SingleEuroPaymentsArea, // same ordinal as derivation source for type conversions
    
}
