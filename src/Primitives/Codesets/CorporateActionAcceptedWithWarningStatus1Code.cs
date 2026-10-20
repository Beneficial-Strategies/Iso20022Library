// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Accepted with warning status of the corporate action notification advice coming from the issuer agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yl-FoKUcEfCnE_wCEfCqTA")]
[Description(@"Accepted with warning status of the corporate action notification advice coming from the issuer agent.")]
[DerivedFrom(typeof(CorporateActionAcceptedWithWarningStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionAcceptedWithWarningStatus1Code>))]
public enum CorporateActionAcceptedWithWarningStatus1Code
{
    /// <summary>
    /// Invalid Security Called Amount.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_OyvmIaUeEfCnE_wCEfCqTA")]
    [Description(@"Invalid Security Called Amount.")]
    InvalidSecurityCalledAmount = CorporateActionAcceptedWithWarningStatusCode.InvalidSecurityCalledAmount,

    /// <summary>
    /// Payable Date outside of applicable date range.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_O3ZcoaUeEfCnE_wCEfCqTA")]
    [Description(@"Payable Date outside of applicable date range.")]
    PayableDateOutsideRange = CorporateActionAcceptedWithWarningStatusCode.PayableDateOutsideRange,
}
