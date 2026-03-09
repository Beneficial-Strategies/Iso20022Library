// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryuGliEeGaMcKyqKNRfQ_4555923")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeCode))]
public enum InvestorType1Code
{
    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_haryuWliEeGaMcKyqKNRfQ_-1196008348")]
    [Description(@"Investor is a retail investor.")]
    Retail = InvestorTypeCode.Retail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is a professional or institutional investor.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_haryumliEeGaMcKyqKNRfQ_271140415")]
    [Description(@"Investor is a professional or institutional investor.")]
    Professional = InvestorTypeCode.Professional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is an employee.
    /// Encoded/decoded by serializers as &quot;STAF&quot;.
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_haryu2liEeGaMcKyqKNRfQ_-1207107125")]
    [Description(@"Investor is an employee.")]
    Staff = InvestorTypeCode.Staff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is a physical person.
    /// Encoded/decoded by serializers as &quot;PPER&quot;.
    /// </summary>
    [EnumMember(Value = "PPER")]
    [IsoId("_haryvGliEeGaMcKyqKNRfQ_260041638")]
    [Description(@"Investor is a physical person.")]
    PhysicalPerson = InvestorTypeCode.PhysicalPerson, // same ordinal as derivation source for type conversions
    
}
