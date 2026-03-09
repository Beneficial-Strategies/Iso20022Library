// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash in lieu payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1s_1BjL3EeKU9IrkkToqcw_1334650704")]
[Description(@"Specifies the cash in lieu payment type.")]
[DerivedFrom(typeof(CILPaymentTypeCode))]
public enum CILPaymentType1Code
{
    /// <summary>
    /// Event pays daily at fixed rate.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_1tJmADL3EeKU9IrkkToqcw_1674898907")]
    [Description(@"Event pays daily at fixed rate.")]
    Fixed = CILPaymentTypeCode.Fixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price can fluctuate. Payment is held until released.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_1tJmATL3EeKU9IrkkToqcw_1955757868")]
    [Description(@"Price can fluctuate. Payment is held until released.")]
    Hold = CILPaymentTypeCode.Hold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pays on same day as convert/exercise instructions.
    /// Encoded/decoded by serializers as &quot;PCIL&quot;.
    /// </summary>
    [EnumMember(Value = "PCIL")]
    [IsoId("_1tJmAjL3EeKU9IrkkToqcw_-43100213")]
    [Description(@"Pays on same day as convert/exercise instructions.")]
    PayCIL = CILPaymentTypeCode.PayCIL, // same ordinal as derivation source for type conversions
    
}
