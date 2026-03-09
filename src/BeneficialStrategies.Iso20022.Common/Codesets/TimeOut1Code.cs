// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for time-out.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VrxOB9p-Ed-ak6NoX_4Aeg_1157189498")]
[Description(@"Specifies the reason for time-out.")]
[DerivedFrom(typeof(TimeOutCode))]
public enum TimeOut1Code
{
    /// <summary>
    /// Reason for time-out is the reaching of latest shipment date.
    /// Encoded/decoded by serializers as &quot;LSDD&quot;.
    /// </summary>
    [EnumMember(Value = "LSDD")]
    [IsoId("_VrxOCNp-Ed-ak6NoX_4Aeg_1511821876")]
    [Description(@"Reason for time-out is the reaching of latest shipment date.")]
    LatestShipmentDateDue = TimeOutCode.LatestShipmentDateDue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for time-out is the lack of action from the user side.
    /// Encoded/decoded by serializers as &quot;NACT&quot;.
    /// </summary>
    [EnumMember(Value = "NACT")]
    [IsoId("_Vr6_ANp-Ed-ak6NoX_4Aeg_1511821877")]
    [Description(@"Reason for time-out is the lack of action from the user side.")]
    NoAction = TimeOutCode.NoAction, // same ordinal as derivation source for type conversions
    
}
