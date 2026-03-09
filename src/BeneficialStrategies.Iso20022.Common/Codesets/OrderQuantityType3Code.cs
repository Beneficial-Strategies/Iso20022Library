// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the order is placed, for example by quantity of units or by amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRVD49p-Ed-ak6NoX_4Aeg_-1276786595")]
[Description(@"Specifies how the order is placed, for example by quantity of units or by amount of money.")]
[DerivedFrom(typeof(OrderQuantityTypeCode))]
public enum OrderQuantityType3Code
{
    /// <summary>
    /// Order is placed by unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_aRVD5Np-Ed-ak6NoX_4Aeg_-122386355")]
    [Description(@"Order is placed by unit.")]
    Unit = OrderQuantityTypeCode.Unit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is placed by amount of money.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aRVD5dp-Ed-ak6NoX_4Aeg_-122386320")]
    [Description(@"Order is placed by amount of money.")]
    Amount = OrderQuantityTypeCode.Amount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For futures - units of Measure per Time Unit (if used - must specify UnitofMeasure and TimeUnit.
    /// Encoded/decoded by serializers as &quot;UMPU&quot;.
    /// </summary>
    [EnumMember(Value = "UMPU")]
    [IsoId("_aRVD5tp-Ed-ak6NoX_4Aeg_-122385935")]
    [Description(@"For futures - units of Measure per Time Unit (if used - must specify UnitofMeasure and TimeUnit.")]
    UnitsOfMeasurePerTimeUnit = OrderQuantityTypeCode.UnitsOfMeasurePerTimeUnit, // same ordinal as derivation source for type conversions
    
}
