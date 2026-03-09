// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies messages related to a network management process.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DZ7GgFULEeetiruPyDPo0Q")]
[Description(@"Identifies messages related to a network management process.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction23Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_W52kcemuEemNVKPwszFC-A")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_YVDXIemuEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
}
