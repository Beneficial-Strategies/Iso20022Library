// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of event processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDij9dp-Ed-ak6NoX_4Aeg_-1352374921")]
[Description(@"Specifies the type of event processing.")]
[Derivations(typeof(CorporateActionEventProcessingType1Code))]
public enum CorporateActionEventProcessingTypeCode
{
    /// <summary>
    /// No debit or credit of resources.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_bDij9tp-Ed-ak6NoX_4Aeg_-1333902672")]
    [Description(@"No debit or credit of resources.")]
    General,

    /// <summary>
    /// Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_bDij99p-Ed-ak6NoX_4Aeg_-1333902641")]
    [Description(
        @"Holder of the relevant security on a certain date, for example, the record date, will receive a benefit without giving up the underlying security."
    )]
    Distribution,

    /// <summary>
    /// Underlying security will be debited and may be replaced by another resource (or resources).
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_bDij-Np-Ed-ak6NoX_4Aeg_-1333902640")]
    [Description(
        @"Underlying security will be debited and may be replaced by another resource (or resources)."
    )]
    Reorganisation,
}
