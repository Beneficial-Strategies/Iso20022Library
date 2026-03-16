// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of event processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDij8dp-Ed-ak6NoX_4Aeg_-1578927288")]
[Description(@"Specifies the type of event processing.")]
[DerivedFrom(typeof(CorporateActionEventProcessingTypeCode))]
public enum CorporateActionEventProcessingType1Code
{
    /// <summary>
    /// No debit or credit of resources.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_bDij8tp-Ed-ak6NoX_4Aeg_-1292636681")]
    [Description(@"No debit or credit of resources.")]
    General = CorporateActionEventProcessingTypeCode.General, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_bDij89p-Ed-ak6NoX_4Aeg_-1292636650")]
    [Description(
        @"Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security."
    )]
    Distribution = CorporateActionEventProcessingTypeCode.Distribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying security will be debited and may be replaced by another resource (or resources).
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_bDij9Np-Ed-ak6NoX_4Aeg_-1292636649")]
    [Description(
        @"Underlying security will be debited and may be replaced by another resource (or resources)."
    )]
    Reorganisation = CorporateActionEventProcessingTypeCode.Reorganisation, // same ordinal as derivation source for type conversions
}
