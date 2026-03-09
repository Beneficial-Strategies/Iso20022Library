// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ah3aRNp-Ed-ak6NoX_4Aeg_-1106717300")]
[Description(@"Error codes generated when the response to a query exceeds the maximum size or the data is not available.")]
[DerivedFrom(typeof(ErrorHandlingCode))]
public enum ErrorHandling1Code
{
    /// <summary>
    /// Specifies the error code when the data requested are not yet available.
    /// Encoded/decoded by serializers as &quot;X020&quot;.
    /// </summary>
    [EnumMember(Value = "X020")]
    [IsoId("_ah3aRdp-Ed-ak6NoX_4Aeg_-1106717261")]
    [Description(@"Specifies the error code when the data requested are not yet available.")]
    DataNotYetAvailable = ErrorHandlingCode.DataNotYetAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the error code when the data requested generates a message size that exceed the processing capacity.
    /// Encoded/decoded by serializers as &quot;X030&quot;.
    /// </summary>
    [EnumMember(Value = "X030")]
    [IsoId("_ah3aRtp-Ed-ak6NoX_4Aeg_-1106717021")]
    [Description(@"Specifies the error code when the data requested generates a message size that exceed the processing capacity.")]
    MessageSizeLimitExceeded = ErrorHandlingCode.MessageSizeLimitExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the error code when the data requested have not been found.
    /// Encoded/decoded by serializers as &quot;X050&quot;.
    /// </summary>
    [EnumMember(Value = "X050")]
    [IsoId("_ah3aR9p-Ed-ak6NoX_4Aeg_-1106717013")]
    [Description(@"Specifies the error code when the data requested have not been found.")]
    DataNotAvailable = ErrorHandlingCode.DataNotAvailable, // same ordinal as derivation source for type conversions
    
}
