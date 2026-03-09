// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the stage of the CA lottery event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nc7WUCUmEeO8eOSw0QN9mA")]
[Description(@"Specifies the stage of the CA lottery event.")]
[DerivedFrom(typeof(CorporateActionEventStageV2Code))]
public enum CorporateActionEventStage4Code
{
    /// <summary>
    /// Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_5wragSUmEeO8eOSw0QN9mA")]
    [Description(@"Cancellation and re-run of an original lottery or an original and supplemental lottery. A subsequent lottery will be performed under a new event.")]
    CancellationAndReRun = CorporateActionEventStageV2Code.CancellationAndReRun, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_6CSu8SUmEeO8eOSw0QN9mA")]
    [Description(@"Cancellation and re-run of a supplemental lottery only. A subsequent new supplemental lottery will be performed under the original event.")]
    SupplementalCancellationAndReRun = CorporateActionEventStageV2Code.SupplementalCancellationAndReRun, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_6OILgSUmEeO8eOSw0QN9mA")]
    [Description(@"A supplemental lottery is being cancelled by the issuer. No subsequent lottery will be performed.")]
    SupplementalCancellation = CorporateActionEventStageV2Code.SupplementalCancellation, // same ordinal as derivation source for type conversions
    
}
