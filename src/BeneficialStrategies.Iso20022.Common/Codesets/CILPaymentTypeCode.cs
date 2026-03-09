// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies cash in lieu payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1n7u0jL3EeKU9IrkkToqcw_2037230597")]
[Description(@"Specifies cash in lieu payment type.")]
[Derivations(typeof(CILPaymentType1Code))]
public enum CILPaymentTypeCode
{
    /// <summary>
    /// Event pays daily at fixed rate.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_1n7u0zL3EeKU9IrkkToqcw_-110040090")]
    [Description(@"Event pays daily at fixed rate.")]
    Fixed,
    
    /// <summary>
    /// Price can fluctuate. Payment is held until released.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_1n7u1DL3EeKU9IrkkToqcw_-307768782")]
    [Description(@"Price can fluctuate. Payment is held until released.")]
    Hold,
    
    /// <summary>
    /// Pays on same day as convert/exercise instructions.
    /// Encoded/decoded by serializers as &quot;PCIL&quot;.
    /// </summary>
    [EnumMember(Value = "PCIL")]
    [IsoId("_1n7u1TL3EeKU9IrkkToqcw_-1762418008")]
    [Description(@"Pays on same day as convert/exercise instructions.")]
    PayCIL,
    
}
