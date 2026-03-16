// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rN-VgC7QEemIy6A-26wnAg")]
[Description(@"Type of customer.")]
[DerivedFrom(typeof(CustomerTypeCode))]
public enum CustomerType2Code
{
    /// <summary>
    /// Consumer
    /// Encoded/decoded by serializers as &quot;CSMR&quot;.
    /// </summary>
    [EnumMember(Value = "CSMR")]
    [IsoId("_56414S7QEemIy6A-26wnAg")]
    [Description(@"Consumer")]
    Consumer = CustomerTypeCode.Consumer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Company
    /// Encoded/decoded by serializers as &quot;CPNY&quot;.
    /// </summary>
    [EnumMember(Value = "CPNY")]
    [IsoId("_6R19US7QEemIy6A-26wnAg")]
    [Description(@"Company")]
    Company = CustomerTypeCode.Company, // same ordinal as derivation source for type conversions
}
