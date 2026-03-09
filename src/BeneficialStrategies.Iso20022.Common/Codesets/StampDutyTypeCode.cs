// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPdXN9p-Ed-ak6NoX_4Aeg_930727871")]
[Description(@"Specifies if the stamp duty is applicable.")]
[Derivations(typeof(StampDutyType2Code),typeof(StampDutyType1Code))]
public enum StampDutyTypeCode
{
    /// <summary>
    /// SDRT paid outside of CSD on corporate action.
    /// Encoded/decoded by serializers as &quot;SDRU&quot;.
    /// </summary>
    [EnumMember(Value = "SDRU")]
    [IsoId("_ZPdXONp-Ed-ak6NoX_4Aeg_999066501")]
    [Description(@"SDRT paid outside of CSD on corporate action.")]
    OutsideCSD,
    
    /// <summary>
    /// SDRT paid on another transaction.
    /// Encoded/decoded by serializers as &quot;SDRT&quot;.
    /// </summary>
    [EnumMember(Value = "SDRT")]
    [IsoId("_ZPnIMNp-Ed-ak6NoX_4Aeg_999066531")]
    [Description(@"SDRT paid on another transaction.")]
    Paid,
    
    /// <summary>
    /// Stamp duty not applicable.
    /// Encoded/decoded by serializers as &quot;SDRN&quot;.
    /// </summary>
    [EnumMember(Value = "SDRN")]
    [IsoId("_ZPnIMdp-Ed-ak6NoX_4Aeg_999066562")]
    [Description(@"Stamp duty not applicable.")]
    NotApplicable,
    
    /// <summary>
    /// Exempt, for any other reason.
    /// Encoded/decoded by serializers as &quot;SDRQ&quot;.
    /// </summary>
    [EnumMember(Value = "SDRQ")]
    [IsoId("_ZPnIMtp-Ed-ak6NoX_4Aeg_999066810")]
    [Description(@"Exempt, for any other reason.")]
    Exemption,
    
    /// <summary>
    /// Stamps duty is applicable.
    /// Encoded/decoded by serializers as &quot;ASTD&quot;.
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_oTfCx_piEeCG_oUHBFcYXA")]
    [Description(@"Stamps duty is applicable.")]
    Applicable,
    
}
