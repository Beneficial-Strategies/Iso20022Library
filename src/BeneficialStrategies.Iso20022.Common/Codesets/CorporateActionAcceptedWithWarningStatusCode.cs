// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Accepted with warning status of the corporate action notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OBTe8KUaEfCIzrotrg4VRw")]
[Description(@"Accepted with warning status of the corporate action notification.")]
[Derivations(typeof(CorporateActionAcceptedWithWarningStatus1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionAcceptedWithWarningStatusCode>))]
public enum CorporateActionAcceptedWithWarningStatusCode
{
    /// <summary>
    /// Invalid Security Called Amount.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_elGBYKUaEfCIzrotrg4VRw")]
    [Description(@"Invalid Security Called Amount.")]
    InvalidSecurityCalledAmount,

    /// <summary>
    /// Payable Date outside of applicable date range.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_oHtAEaUaEfCIzrotrg4VRw")]
    [Description(@"Payable Date outside of applicable date range.")]
    PayableDateOutsideRange,
}
