// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the pre-agreed level of service between the parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKjCBtp-Ed-ak6NoX_4Aeg_27077398")]
[Description(@"Specifies the pre-agreed level of service between the parties.")]
[Derivations(typeof(ServiceLevel1Code),typeof(ServiceLevel2Code),typeof(ServiceLevel4Code),typeof(ServiceLevel3Code))]
public enum ServiceLevelCode
{
    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// Encoded/decoded by serializers as &quot;SDVA&quot;.
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_ZKjCB9p-Ed-ak6NoX_4Aeg_269040383")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SameDayValue,
    
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_ZKjCCNp-Ed-ak6NoX_4Aeg_354928380")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea,
    
    /// <summary>
    /// Transaction must be processed according to the EBA|Priority Service.
    /// Encoded/decoded by serializers as &quot;PRPT&quot;.
    /// </summary>
    [EnumMember(Value = "PRPT")]
    [IsoId("_ZKsL8Np-Ed-ak6NoX_4Aeg_1356003774")]
    [Description(@"Transaction must be processed according to the EBA|Priority Service.")]
    EBAPriorityService,
    
}
